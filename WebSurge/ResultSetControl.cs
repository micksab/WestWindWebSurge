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
        private HttpResultSet _set;
        private HttpResultSet.ListType _mode;
        private IResultSetControlContainer _container;

        public event EventHandler<ResultSetControlEventArgs> OnMoveToExcludedList_Click;
        public event EventHandler<ResultSetControlEventArgs> OnMoveToIncludedList_Click;
        public event EventHandler<ResultSetControlEventArgs> OnMoveUp_Click;
        public event EventHandler<ResultSetControlEventArgs> OnMoveDown_Click;
        public event EventHandler<ResultSetControlEventArgs> OnEdit_Click;

        public ResultSetControl(IResultSetControlContainer container, HttpResultSet resultSet, HttpResultSet.ListType mode)
        {
            InitializeComponent();

            _set = resultSet;
            SetMode(mode);
            _container = container;

            RefreshResultSetControl();
            RegisterToContainerHandlers();
            

        }
       

        public void RefreshResultSetControl()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;

            txtTitle.Text = _set.Title == string.Empty ? "---" : _set.Title;
            txtFilename.Text = _set.Filename == string.Empty ? "---" : _set.Filename;
            txtUrl.Text = _set.Url;
            txtDate.Text = _set.Date.ToLocalTime().ToString("g", ci);
            txtDuration.Text = string.Format("{0:0.00} seconds", _set.DurationSeconds);

            
        }

        private void RegisterToContainerHandlers()
        {
            //Self-register to the parent container's IResultSetControlContainer event handlers
            OnMoveUp_Click += new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlUp_Click);
            OnMoveDown_Click += new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlDown_Click);
            OnMoveToExcludedList_Click += new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlMoveToExcluded_Click);
            OnMoveToIncludedList_Click += new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlMoveToIncluded_Click);
            OnEdit_Click += new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlDataChange_Click);

        }

        private void UnegisterFromContainerHandlers()
        {
            //Self-unregister to the parent container's IResultSetControlContainer event handlers
            OnMoveUp_Click -= new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlUp_Click);
            OnMoveDown_Click -= new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlDown_Click);
            OnMoveToExcludedList_Click -= new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlMoveToExcluded_Click);
            OnMoveToIncludedList_Click -= new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlMoveToIncluded_Click);
            OnEdit_Click -= new EventHandler<ResultSetControlEventArgs>(_container.ResultSetControlDataChange_Click);
        }


        public void SetMode(HttpResultSet.ListType mode)
        {
            _mode = mode;
            btnRight.Enabled = (mode == HttpResultSet.ListType.Included ? false : true);
            btnLeft.Enabled = (mode == HttpResultSet.ListType.Included ? true : false);
        }

         

        private void Button_Click(object sender, EventArgs e)
        {
            if(sender == btnUp)
                OnMoveUp_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if(sender== btnDown)
                OnMoveDown_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if (sender == btnLeft)
                OnMoveToExcludedList_Click?.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if (sender == btnRight)
                OnMoveToIncludedList_Click.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
            else if (sender == btnEdit)
                OnEdit_Click.Invoke(this, new ResultSetControlEventArgs(_set, _mode));
        }

        private void ResultSetControl_LocationChanged(object sender, EventArgs e)
        {
            if (ReferenceEquals(Parent.Controls.OfType<ResultSetControl>().FirstOrDefault(), this))
            {
                btnUp.Enabled = false;
            }
            else if (ReferenceEquals(Parent.Controls.OfType<ResultSetControl>().LastOrDefault(), this))
            {
                btnDown.Enabled = false;
            }
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        private void ResultSetControl_Enter(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void ResultSetControl_Leave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }
    }


    public class ResultSetControlEventArgs : EventArgs
    {
        public HttpResultSet ResultSet { get; }
        public HttpResultSet.ListType Mode { get; }

        public ResultSetControlEventArgs(HttpResultSet set, HttpResultSet.ListType mode) : base()
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
