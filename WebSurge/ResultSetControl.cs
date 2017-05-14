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
using static WebSurge.ResultSetControl;

namespace WebSurge
{
    public partial class ResultSetControl : UserControl
    {
        public enum ControlMode
        {
            Included, 
            Excluded
        }

        private HttpResultSet _set;
        private ControlMode _mode;

        public event EventHandler<ResultSetControlEventArgs> MoveToExcludedList_Click;
        public event EventHandler<ResultSetControlEventArgs> MoveToIncludedList_Click;
        public event EventHandler<ResultSetControlEventArgs> MoveUp_Click;
        public event EventHandler<ResultSetControlEventArgs> MoveDown_Click;
        public event EventHandler<ResultSetControlEventArgs> DataChange_Click;

        public ResultSetControl(IResultSetControlContainer container, HttpResultSet resultSet, ControlMode mode)
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CurrentCulture;

            _set = resultSet;
            _mode = mode;
            txtTitle.Text = _set.Title == string.Empty ? "---" : _set.Title;
            txtFilename.Text = _set.Filename == string.Empty ? "---" : _set.Filename;
            txtUrl.Text = _set.Url;
            txtDate.Text = _set.Date.ToLocalTime().ToString("g", ci);
            txtDuration.Text = string.Format("{0:0.00} seconds", _set.DurationSeconds);

            switch(mode)
            {
                case ControlMode.Included:
                    btnRight.Enabled = true;
                    btnLeft.Enabled = false;
                    break;
                default:
                    btnRight.Enabled = false;
                    btnLeft.Enabled = true;
                    break;
            }

            MoveUp_Click += new EventHandler<ResultSetControlEventArgs>(container.ResultSetControlUp_Click);
            MoveDown_Click += new EventHandler<ResultSetControlEventArgs>(container.ResultSetControlDown_Click);
            MoveToExcludedList_Click += new EventHandler<ResultSetControlEventArgs>(container.ResultSetControlMoveToExcluded_Click);
            MoveToIncludedList_Click += new EventHandler<ResultSetControlEventArgs>(container.ResultSetControlMoveToIncluded_Click);
            DataChange_Click += new EventHandler<ResultSetControlEventArgs>(container.ResultSetControlDataChange_Click);

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(sender == btnUp)
                MoveUp_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if(sender== btnDown)
                MoveDown_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if (sender == btnLeft)
                MoveToExcludedList_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if (sender == btnRight)
                MoveToIncludedList_Click.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else
                throw new NotImplementedException();
        }
    }


    public class ResultSetControlEventArgs : EventArgs
    {
        public HttpResultSet ResultSet { get; }
        public ControlMode Mode { get; }

        public ResultSetControlEventArgs(HttpResultSet set, ControlMode mode) : base()
        {
            ResultSet = set;
            Mode = mode;
        }
    }


    public interface IResultSetControlContainer
    {
        void ResultSetControlUp_Click(object sender, ResultSetControlEventArgs e);
        void ResultSetControlDown_Click(object sender, ResultSetControlEventArgs e);
        void ResultSetControlMoveToExcluded_Click(object sender, ResultSetControlEventArgs e);
        void ResultSetControlMoveToIncluded_Click(object sender, ResultSetControlEventArgs e);
        void ResultSetControlDataChange_Click(object sender, ResultSetControlEventArgs e);
    }
}
