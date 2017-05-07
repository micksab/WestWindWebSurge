using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSurge
{
    public partial class ImportResultsForm : Form
    {
        List<HttpRequestData> _currentResults;
        List<HttpResultSet> _includedData = new List<HttpResultSet>();
        List<HttpResultSet> _excludedData = new List<HttpResultSet>();

        public ImportResultsForm(List<HttpRequestData> currentResults)
        {
            InitializeComponent();
            _currentResults = currentResults;
            _includedData = HttpResultSet.GetHttpResultSetsFromRequests(currentResults, null);
            string test = string.Empty;
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }
    }


    public class HttpResultSet
    {
        protected Guid Id;
        protected string Filename;
        protected string Url;
        protected string Title;
        protected DateTime Date;
        protected double DurationSeconds;
        protected List<HttpRequestData> Data;

        public HttpResultSet(string filename, string url, string title, DateTime date, double duration, List<HttpRequestData> data)
        {
            Id = Guid.NewGuid();
            Filename = (filename == null ? string.Empty:filename) ;
            Url = url;
            Title = title;
            Date = date;
            DurationSeconds = duration;
            Data = data;
        }


        public static List<HttpResultSet> GetHttpResultSetsFromRequests(List<HttpRequestData> data, string filename)
        {
            List<HttpResultSet> toReturn = new List<HttpResultSet>();

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
