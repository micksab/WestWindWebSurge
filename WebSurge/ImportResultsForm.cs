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

        public ImportResultsForm(List<HttpRequestData> currentResults)
        {
            InitializeComponent();
            _includedData = HttpResultSet.GetHttpResultSetsFromRequests(currentResults, null);
        }

        private void ImportResultsForm_Shown(object sender, EventArgs e)
        {
            RefreshUILists(HttpResultSet.ListType.Included);
        }

        

        

        private void RefreshUILists(HttpResultSet.ListType type)
        {
            if(type== HttpResultSet.ListType.Included)
            {
                includedFlowPanel.SuspendLayout();
                includedFlowPanel.Controls.Clear();
                foreach (HttpResultSet set in _includedData)
                {
                    ResultSetControl controlToAdd = new ResultSetControl(this, set, HttpResultSet.ListType.Included);
                    includedFlowPanel.Controls.Add(controlToAdd);
                }
                includedFlowPanel.ResumeLayout();
                return;
            }
            
            if(type == HttpResultSet.ListType.Excluded)
            {
                excludedFlowPanel.SuspendLayout();
                excludedFlowPanel.Controls.Clear();
                foreach (HttpResultSet set in _excludedData)
                {
                    ResultSetControl controlToAdd = new ResultSetControl(this, set, HttpResultSet.ListType.Excluded);
                    excludedFlowPanel.Controls.Add(controlToAdd);
                }
                excludedFlowPanel.ResumeLayout();

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
            int position = 0;
            ResultSetControl control = (ResultSetControl)sender;
            switch (e.Mode)
            {
                case HttpResultSet.ListType.Included:
                    position = _includedData.IndexOf(e.ResultSet);
                    _includedData.Move(position, position - 1);
                    includedFlowPanel.Controls.SetChildIndex(control, position - 1);
                    includedFlowPanel.ScrollControlIntoView(control);
                    break;
                default:
                    position = _excludedData.IndexOf(e.ResultSet);
                    _excludedData.Move(position, position - 1);
                    excludedFlowPanel.Controls.SetChildIndex(control, position - 1);
                    excludedFlowPanel.ScrollControlIntoView(control);
                    break;
            }
        }

        public void ResultSetControlDown_Click(object sender, ResultSetControlEventArgs e)
        {
            int position = 0;
            ResultSetControl control = (ResultSetControl)sender;
            switch (e.Mode)
            {
                case HttpResultSet.ListType.Included:
                    position = _includedData.IndexOf(e.ResultSet);
                    _includedData.Move(position, position + 1);
                    includedFlowPanel.Controls.SetChildIndex(control, position + 1);
                    includedFlowPanel.ScrollControlIntoView(control);
                    break;
                default:
                    position = _excludedData.IndexOf(e.ResultSet);
                    _excludedData.Move(position, position + 1);
                    excludedFlowPanel.Controls.SetChildIndex(control, position + 1);
                    excludedFlowPanel.ScrollControlIntoView(control);
                    break;
            }
        }

        public void ResultSetControlMoveToExcluded_Click(object sender, ResultSetControlEventArgs e)
        {
            ResultSetControl control = (ResultSetControl)sender;
            HttpResultSet set = e.ResultSet;

            control.SetMode(HttpResultSet.ListType.Excluded);
            _includedData.Remove(set);
            includedFlowPanel.Controls.Remove(control);
            _excludedData.Add(set);
            excludedFlowPanel.Controls.Add(control);
            control.Focus();
            excludedFlowPanel.ScrollControlIntoView(control);
        }

        public void ResultSetControlMoveToIncluded_Click(object sender, ResultSetControlEventArgs e)
        {
            ResultSetControl control = (ResultSetControl)sender;
            HttpResultSet set = e.ResultSet;

            control.SetMode(HttpResultSet.ListType.Included);
            _excludedData.Remove(set);
            excludedFlowPanel.Controls.Remove(control);
            _includedData.Add(set);
            includedFlowPanel.Controls.Add(control);
            control.Focus();
            includedFlowPanel.ScrollControlIntoView(control);
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

        public enum ListType
        {
            Included,
            Excluded
        }

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
