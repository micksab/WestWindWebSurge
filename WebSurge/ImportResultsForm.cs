using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSurge
{
    public partial class ImportResultsForm : Form, IResultSetControlContainer
    {
        ObservableCollection<HttpResultSet> _includedData = new ObservableCollection<HttpResultSet>();
        ObservableCollection<HttpResultSet> _excludedData = new ObservableCollection<HttpResultSet>();

        private enum ImportFileType
        {
            None,
            Raw, 
            Json, 
            Xml
        }

        private enum ListType
        {
            Included, 
            Excluded
        }

        public ImportResultsForm(List<HttpRequestData> currentResults)
        {
            InitializeComponent();
            _includedData.CollectionChanged += IncludedData_CollectionChanged;
            _excludedData.CollectionChanged += ExcludedData_CollectionChanged;
            _includedData = HttpResultSet.GetHttpResultSetsFromRequests(currentResults, null);
        }

        private void ImportResultsForm_Shown(object sender, EventArgs e)
        {
            RefreshUILists(ListType.Included);
        }

        private void ExcludedData_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshUILists(ListType.Excluded);
        }

        private void IncludedData_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshUILists(ListType.Included);
        }

        

        private void RefreshUILists(ListType type)
        {
            if(type== ListType.Included)
            {
                includedFlowPanel.Controls.Clear();
                foreach (HttpResultSet set in _includedData)
                {
                    ResultSetControl controlToAdd = new ResultSetControl(this, set, ResultSetControl.ControlMode.Included);
                    includedFlowPanel.Controls.Add(controlToAdd);
                }
                return;
            }
            
            if(type == ListType.Excluded)
            {
                importedFlowPanel.Controls.Clear();
                foreach (HttpResultSet set in _excludedData)
                {
                    ResultSetControl controlToAdd = new ResultSetControl(this, set, ResultSetControl.ControlMode.Excluded);
                    importedFlowPanel.Controls.Add(controlToAdd);
                }
                return;
            }
        }


        public void ImportButtonClick(object sender, EventArgs e)
        {
            ImportFileType type = ImportFileType.None;

            if (sender == tbImportRaw)
                type = ImportFileType.Raw;
            else if (sender == tbImportJson)
                type = ImportFileType.Json;
            else if (sender == tbImportXml)
                type = ImportFileType.Xml;
            else
                throw new NotImplementedException();
            
            try
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    string fullFilePath = string.Empty;
                    openDialog.InitialDirectory = "c:\\";
                    openDialog.RestoreDirectory = true;
                    openDialog.Filter = GetFileTypeOpenDialogFilter(type);


                    if (openDialog.ShowDialog() == DialogResult.OK)
                        fullFilePath = openDialog.FileName;
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( string.Concat("Error while trying to load saved results: ", ex.Message), 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }     
        }

        private string GetFileTypeOpenDialogFilter(ImportFileType type)
        {
            string toReturn = string.Empty;

            switch (type)
            {
                case ImportFileType.Raw:
                    toReturn = "Raw WebSurge Files (*.websurge)|*.websurge";
                    break;
                case ImportFileType.Json:
                    toReturn = "Json Files (*.json)|*.json";
                    break;
                case ImportFileType.Xml:
                    toReturn = "XML Files (*.xml)|*.xml";
                    break;
                default:
                    throw new NotImplementedException();
            }

            return toReturn;
        }

        public void ResultSetControlUp_Click(object sender, ResultSetControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ResultSetControlDown_Click(object sender, ResultSetControlEventArgs e)
        {
            if (e.Mode== ResultSetControl.ControlMode.Included)
            {
                int position = _includedData.IndexOf(e.ResultSet);
                if (position < _includedData.Count - 2)
                    _includedData.Move(position, position + 1);
            }
            else
            {
                int position = _excludedData.IndexOf(e.ResultSet);
                if (position < _excludedData.Count - 2)
                    _excludedData.Move(position, position + 1);
            }
        }

        public void ResultSetControlMoveToExcluded_Click(object sender, ResultSetControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ResultSetControlMoveToIncluded_Click(object sender, ResultSetControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ResultSetControlDataChange_Click(object sender, ResultSetControlEventArgs e)
        {
            throw new NotImplementedException();
        }
    }


    public class HttpResultSet
    {
        public Guid Id { get; private set; }
        public string Filename { get; private set; }
        public string Url { get; private set; }
        public string Title { get; set; }
        public DateTime Date { get; private set; }
        public double DurationSeconds { get; private set; }
        public List<HttpRequestData> Data;

        public HttpResultSet(string filename, string url, string title, DateTime date, double duration, List<HttpRequestData> data)
        {
            Id = Guid.NewGuid();
            Filename = (filename == null ? string.Empty:filename) ;
            Url = url;
            Title = (title == null ? string.Empty : title);
            Date = date;
            DurationSeconds = duration;
            Data = data;
        }


        public static ObservableCollection<HttpResultSet> GetHttpResultSetsFromRequests(List<HttpRequestData> data, string filename)
        {
           ObservableCollection<HttpResultSet> toReturn = new ObservableCollection<HttpResultSet>();

            var sets = (from d in data
                        select new { d.Url, d.Name }).Distinct().ToList();

            foreach(var set in sets)
            {
                DateTime minDateTime = (from d in data
                                 where d.Url.Equals(set.Url)
                                 && d.Name.Equals(set.Name)
                                 select d.Timestamp).Min();

                DateTime maxDateTime = (from d in data
                                        where d.Url.Equals(set.Url)
                                        && d.Name.Equals(set.Name)
                                        select d.Timestamp).Max();

                double duration = maxDateTime.Subtract(minDateTime).TotalSeconds;

                List<HttpRequestData> reqData = (from d in data
                                                 where d.Url.Equals(set.Url)
                                                 && d.Name.Equals(set.Name)
                                                 select d).ToList();

                toReturn.Add(new HttpResultSet(filename, set.Url, set.Name, minDateTime, duration, reqData));
            }


            return toReturn;
        }
    }
}
