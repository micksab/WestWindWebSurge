namespace WebSurge
{
    partial class ResultSetControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultSetControl));
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 5;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlPanel.Controls.Add(this.btnEdit, 3, 1);
            this.tlPanel.Controls.Add(this.btnUp, 2, 0);
            this.tlPanel.Controls.Add(this.btnRight, 4, 1);
            this.tlPanel.Controls.Add(this.btnLeft, 2, 1);
            this.tlPanel.Controls.Add(this.btnDown, 2, 4);
            this.tlPanel.Controls.Add(this.txtDate, 1, 2);
            this.tlPanel.Controls.Add(this.txtDuration, 1, 4);
            this.tlPanel.Controls.Add(this.txtUrl, 1, 1);
            this.tlPanel.Controls.Add(this.txtFilename, 1, 3);
            this.tlPanel.Controls.Add(this.lblDuration, 0, 4);
            this.tlPanel.Controls.Add(this.lblDate, 0, 2);
            this.tlPanel.Controls.Add(this.lblFilename, 0, 3);
            this.tlPanel.Controls.Add(this.lblUrl, 0, 1);
            this.tlPanel.Controls.Add(this.lblTitle, 0, 0);
            this.tlPanel.Controls.Add(this.txtTitle, 1, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Location = new System.Drawing.Point(5, 5);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 5;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPanel.Size = new System.Drawing.Size(354, 109);
            this.tlPanel.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(298, 24);
            this.btnEdit.Name = "btnEdit";
            this.tlPanel.SetRowSpan(this.btnEdit, 3);
            this.btnEdit.Size = new System.Drawing.Size(25, 57);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnUp
            // 
            this.btnUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanel.SetColumnSpan(this.btnUp, 3);
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(274, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(77, 15);
            this.btnUp.TabIndex = 14;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRight
            // 
            this.btnRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(329, 24);
            this.btnRight.Name = "btnRight";
            this.tlPanel.SetRowSpan(this.btnRight, 3);
            this.btnRight.Size = new System.Drawing.Size(22, 57);
            this.btnRight.TabIndex = 13;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(274, 24);
            this.btnLeft.Name = "btnLeft";
            this.tlPanel.SetRowSpan(this.btnLeft, 3);
            this.btnLeft.Size = new System.Drawing.Size(18, 57);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDown
            // 
            this.btnDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlPanel.SetColumnSpan(this.btnDown, 3);
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(274, 87);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(77, 19);
            this.btnDown.TabIndex = 11;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Location = new System.Drawing.Point(73, 45);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(195, 20);
            this.txtDate.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDuration.Location = new System.Drawing.Point(73, 87);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(195, 20);
            this.txtDuration.TabIndex = 8;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(73, 24);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(195, 20);
            this.txtUrl.TabIndex = 7;
            // 
            // txtFilename
            // 
            this.txtFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilename.Location = new System.Drawing.Point(73, 66);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(195, 20);
            this.txtFilename.TabIndex = 6;
            // 
            // lblDuration
            // 
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(3, 84);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 25);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilename
            // 
            this.lblFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(3, 63);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(64, 21);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "Filename:";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrl
            // 
            this.lblUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(3, 21);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(64, 21);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url:";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(73, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(195, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // ResultSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tlPanel);
            this.Name = "ResultSetControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(364, 119);
            this.LocationChanged += new System.EventHandler(this.ResultSetControl_LocationChanged);
            this.Enter += new System.EventHandler(this.ResultSetControl_Enter);
            this.Leave += new System.EventHandler(this.ResultSetControl_Leave);
            this.tlPanel.ResumeLayout(false);
            this.tlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnEdit;
    }
}
