using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WebSurge
{
    public partial class ResultSetControl : UserControl
    {
        public enum ControlMode
        {
            Imported, 
            Included
        }

        private HttpResultSet _set;

        public ResultSetControl(HttpResultSet resultSet, ControlMode mode)
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CurrentCulture;

            _set = resultSet;
            txtTitle.Text = _set.Title == string.Empty ? "---" : _set.Title;
            txtFilename.Text = _set.Filename == string.Empty ? "---" : _set.Filename;
            txtUrl.Text = _set.Url;
            txtDate.Text = _set.Date.ToLocalTime().ToString("g", ci);
            txtDuration.Text = string.Format("{0:0.00} seconds", _set.DurationSeconds);

            switch(mode)
            {
                case ControlMode.Imported:
                    btnRight.Enabled = true;
                    btnLeft.Enabled = false;
                    break;
                default:
                    btnRight.Enabled = false;
                    btnLeft.Enabled = true;
                    break;
            }
        }
    }
}
