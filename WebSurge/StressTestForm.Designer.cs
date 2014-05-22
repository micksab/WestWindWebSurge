﻿namespace WebSurge
{
    partial class StressTestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StressTestForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusFilename = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtProcessingTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TabSessions = new System.Windows.Forms.TabControl();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.SessionToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbAddRequest2 = new System.Windows.Forms.ToolStripButton();
            this.tbEditRequest2 = new System.Windows.Forms.ToolStripButton();
            this.tbDeleteRequest2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveAllRequests2 = new System.Windows.Forms.ToolStripButton();
            this.ListRequests = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbAddRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tbEditRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDeleteRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveAllRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.tabResults = new System.Windows.Forms.TabPage();
            this.ListResults = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Request = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbResultCharts = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRequestsPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tbTimeTakenPerUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbListDisplayMode = new System.Windows.Forms.ComboBox();
            this.TabsResult = new System.Windows.Forms.TabControl();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.PreViewBrowser = new System.Windows.Forms.WebBrowser();
            this.tabRequest = new System.Windows.Forms.TabPage();
            this.lblRequestContent = new System.Windows.Forms.Label();
            this.txtRequestContent = new System.Windows.Forms.TextBox();
            this.btnSaveRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestHeaders = new System.Windows.Forms.TextBox();
            this.txtRequestUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtHttpMethod = new System.Windows.Forms.ComboBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.OptionsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecentSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentFilesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEditFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCharts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRequestsPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimeTakenPerUrlChart = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGotoWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGotoRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbEditFile = new System.Windows.Forms.ToolStripButton();
            this.tbCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbStart = new System.Windows.Forms.ToolStripButton();
            this.tbStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbExport = new System.Windows.Forms.ToolStripSplitButton();
            this.tbExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExportHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCharts = new System.Windows.Forms.ToolStripSplitButton();
            this.tbRequestPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimeTakenPerUrlChart = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbtxtTimeToRun = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbtxtThreads = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbNoProgressEvents = new System.Windows.Forms.ToolStripButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRunRequest = new System.Windows.Forms.Button();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).BeginInit();
            this.BottomSplitContainer.Panel1.SuspendLayout();
            this.BottomSplitContainer.Panel2.SuspendLayout();
            this.BottomSplitContainer.SuspendLayout();
            this.TabSessions.SuspendLayout();
            this.tabSession.SuspendLayout();
            this.SessionToolStrip.SuspendLayout();
            this.RequestContextMenu.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.ResultContextMenu.SuspendLayout();
            this.TabsResult.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabPreview.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.OptionsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.BottomSplitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(992, 577);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(992, 673);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.MainMenu);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.MainToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.OptionsToolStrip);
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusText,
            this.lblStatusFilename,
            this.txtProcessingTime});
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(992, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = false;
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(300, 17);
            this.lblStatusText.Text = "Ready";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusFilename
            // 
            this.lblStatusFilename.DoubleClickEnabled = true;
            this.lblStatusFilename.Name = "lblStatusFilename";
            this.lblStatusFilename.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStatusFilename.Size = new System.Drawing.Size(667, 17);
            this.lblStatusFilename.Spring = true;
            this.lblStatusFilename.Text = "No Fiddler Session File selected";
            this.lblStatusFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProcessingTime
            // 
            this.txtProcessingTime.DoubleClickEnabled = true;
            this.txtProcessingTime.Name = "txtProcessingTime";
            this.txtProcessingTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtProcessingTime.Size = new System.Drawing.Size(10, 17);
            this.txtProcessingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtProcessingTime.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // BottomSplitContainer
            // 
            this.BottomSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.BottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainer.Name = "BottomSplitContainer";
            // 
            // BottomSplitContainer.Panel1
            // 
            this.BottomSplitContainer.Panel1.Controls.Add(this.TabSessions);
            // 
            // BottomSplitContainer.Panel2
            // 
            this.BottomSplitContainer.Panel2.Controls.Add(this.TabsResult);
            this.BottomSplitContainer.Size = new System.Drawing.Size(992, 577);
            this.BottomSplitContainer.SplitterDistance = 429;
            this.BottomSplitContainer.SplitterIncrement = 2;
            this.BottomSplitContainer.TabIndex = 0;
            // 
            // TabSessions
            // 
            this.TabSessions.Controls.Add(this.tabSession);
            this.TabSessions.Controls.Add(this.tabResults);
            this.TabSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSessions.Location = new System.Drawing.Point(0, 0);
            this.TabSessions.Name = "TabSessions";
            this.TabSessions.SelectedIndex = 0;
            this.TabSessions.Size = new System.Drawing.Size(429, 577);
            this.TabSessions.TabIndex = 3;
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.SessionToolStrip);
            this.tabSession.Controls.Add(this.ListRequests);
            this.tabSession.Location = new System.Drawing.Point(4, 24);
            this.tabSession.Margin = new System.Windows.Forms.Padding(0);
            this.tabSession.Name = "tabSession";
            this.tabSession.Size = new System.Drawing.Size(421, 549);
            this.tabSession.TabIndex = 0;
            this.tabSession.Text = "Session";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // SessionToolStrip
            // 
            this.SessionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAddRequest2,
            this.tbEditRequest2,
            this.tbDeleteRequest2,
            this.toolStripSeparator11,
            this.tbSaveAllRequests2});
            this.SessionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SessionToolStrip.Name = "SessionToolStrip";
            this.SessionToolStrip.Size = new System.Drawing.Size(421, 25);
            this.SessionToolStrip.TabIndex = 5;
            this.SessionToolStrip.Text = "toolStrip1";
            // 
            // tbAddRequest2
            // 
            this.tbAddRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbAddRequest2.Image")));
            this.tbAddRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddRequest2.Name = "tbAddRequest2";
            this.tbAddRequest2.Size = new System.Drawing.Size(51, 22);
            this.tbAddRequest2.Text = "New";
            this.tbAddRequest2.ToolTipText = "Create a new request";
            this.tbAddRequest2.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbEditRequest2
            // 
            this.tbEditRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbEditRequest2.Image")));
            this.tbEditRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEditRequest2.Name = "tbEditRequest2";
            this.tbEditRequest2.Size = new System.Drawing.Size(47, 22);
            this.tbEditRequest2.Text = "Edit";
            this.tbEditRequest2.ToolTipText = "Edit selected request";
            this.tbEditRequest2.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbDeleteRequest2
            // 
            this.tbDeleteRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbDeleteRequest2.Image")));
            this.tbDeleteRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDeleteRequest2.Name = "tbDeleteRequest2";
            this.tbDeleteRequest2.Size = new System.Drawing.Size(60, 22);
            this.tbDeleteRequest2.Text = "Delete";
            this.tbDeleteRequest2.ToolTipText = "Delete selected requests";
            this.tbDeleteRequest2.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSaveAllRequests2
            // 
            this.tbSaveAllRequests2.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveAllRequests2.Image")));
            this.tbSaveAllRequests2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveAllRequests2.Name = "tbSaveAllRequests2";
            this.tbSaveAllRequests2.Size = new System.Drawing.Size(93, 22);
            this.tbSaveAllRequests2.Text = "Save Session";
            this.tbSaveAllRequests2.ToolTipText = "Save session to disk";
            this.tbSaveAllRequests2.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // ListRequests
            // 
            this.ListRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2});
            this.ListRequests.ContextMenuStrip = this.RequestContextMenu;
            this.ListRequests.FullRowSelect = true;
            this.ListRequests.GridLines = true;
            this.ListRequests.HideSelection = false;
            this.ListRequests.Location = new System.Drawing.Point(0, 25);
            this.ListRequests.Margin = new System.Windows.Forms.Padding(0);
            this.ListRequests.Name = "ListRequests";
            this.ListRequests.ShowItemToolTips = true;
            this.ListRequests.Size = new System.Drawing.Size(421, 534);
            this.ListRequests.SmallImageList = this.Images;
            this.ListRequests.TabIndex = 4;
            this.ListRequests.UseCompatibleStateImageBehavior = false;
            this.ListRequests.View = System.Windows.Forms.View.Details;
            this.ListRequests.VirtualListSize = 50;
            this.ListRequests.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListRequests_ItemSelectionChanged);
            this.ListRequests.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListRequests_KeyUp);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Verb";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 480;
            // 
            // RequestContextMenu
            // 
            this.RequestContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAddRequest,
            this.toolStripSeparator8,
            this.tbEditRequest,
            this.tbDeleteRequest,
            this.toolStripSeparator6,
            this.tbSaveAllRequests});
            this.RequestContextMenu.Name = "RequestContextMenu";
            this.RequestContextMenu.Size = new System.Drawing.Size(153, 104);
            this.RequestContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbAddRequest
            // 
            this.tbAddRequest.Name = "tbAddRequest";
            this.tbAddRequest.Size = new System.Drawing.Size(152, 22);
            this.tbAddRequest.Text = "&New Request";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // tbEditRequest
            // 
            this.tbEditRequest.Name = "tbEditRequest";
            this.tbEditRequest.Size = new System.Drawing.Size(152, 22);
            this.tbEditRequest.Text = "Edit Request";
            // 
            // tbDeleteRequest
            // 
            this.tbDeleteRequest.Name = "tbDeleteRequest";
            this.tbDeleteRequest.Size = new System.Drawing.Size(152, 22);
            this.tbDeleteRequest.Text = "Delete Request";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // tbSaveAllRequests
            // 
            this.tbSaveAllRequests.Name = "tbSaveAllRequests";
            this.tbSaveAllRequests.Size = new System.Drawing.Size(152, 22);
            this.tbSaveAllRequests.Text = "&Save all to File";
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "ok");
            this.Images.Images.SetKeyName(1, "error");
            this.Images.Images.SetKeyName(2, "download");
            this.Images.Images.SetKeyName(3, "upload");
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.ListResults);
            this.tabResults.Controls.Add(this.label1);
            this.tabResults.Controls.Add(this.cmbListDisplayMode);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(421, 551);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Status,
            this.Request,
            this.ErrorMessage});
            this.ListResults.ContextMenuStrip = this.ResultContextMenu;
            this.ListResults.FullRowSelect = true;
            this.ListResults.GridLines = true;
            this.ListResults.HideSelection = false;
            this.ListResults.Location = new System.Drawing.Point(0, 37);
            this.ListResults.Name = "ListResults";
            this.ListResults.ShowItemToolTips = true;
            this.ListResults.Size = new System.Drawing.Size(421, 514);
            this.ListResults.SmallImageList = this.Images;
            this.ListResults.TabIndex = 3;
            this.ListResults.UseCompatibleStateImageBehavior = false;
            this.ListResults.View = System.Windows.Forms.View.Details;
            this.ListResults.VirtualListSize = 50;
            this.ListResults.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListResults_ItemSelectionChanged);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // Request
            // 
            this.Request.Text = "Request";
            this.Request.Width = 356;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Width = 209;
            // 
            // ResultContextMenu
            // 
            this.ResultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbResultCharts});
            this.ResultContextMenu.Name = "ResultContextMenu";
            this.ResultContextMenu.Size = new System.Drawing.Size(109, 26);
            this.ResultContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbResultCharts
            // 
            this.tbResultCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRequestsPerSecondChart,
            this.toolStripSeparator9,
            this.tbTimeTakenPerUrl});
            this.tbResultCharts.Name = "tbResultCharts";
            this.tbResultCharts.Size = new System.Drawing.Size(108, 22);
            this.tbResultCharts.Text = "Charts";
            this.tbResultCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbRequestsPerSecondChart
            // 
            this.tbRequestsPerSecondChart.Name = "tbRequestsPerSecondChart";
            this.tbRequestsPerSecondChart.Size = new System.Drawing.Size(183, 22);
            this.tbRequestsPerSecondChart.Text = "Requests per Second";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(180, 6);
            // 
            // tbTimeTakenPerUrl
            // 
            this.tbTimeTakenPerUrl.Name = "tbTimeTakenPerUrl";
            this.tbTimeTakenPerUrl.Size = new System.Drawing.Size(183, 22);
            this.tbTimeTakenPerUrl.Text = "Time Taken per URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(181, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1000 items max";
            // 
            // cmbListDisplayMode
            // 
            this.cmbListDisplayMode.FormattingEnabled = true;
            this.cmbListDisplayMode.Items.AddRange(new object[] {
            "All",
            "Success",
            "Errors"});
            this.cmbListDisplayMode.Location = new System.Drawing.Point(8, 8);
            this.cmbListDisplayMode.Name = "cmbListDisplayMode";
            this.cmbListDisplayMode.Size = new System.Drawing.Size(167, 23);
            this.cmbListDisplayMode.TabIndex = 4;
            this.cmbListDisplayMode.SelectedIndexChanged += new System.EventHandler(this.cmbListDisplayMode_SelectedIndexChanged);
            // 
            // TabsResult
            // 
            this.TabsResult.Controls.Add(this.tabOutput);
            this.TabsResult.Controls.Add(this.tabPreview);
            this.TabsResult.Controls.Add(this.tabRequest);
            this.TabsResult.Controls.Add(this.tabOptions);
            this.TabsResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsResult.ItemSize = new System.Drawing.Size(90, 22);
            this.TabsResult.Location = new System.Drawing.Point(0, 0);
            this.TabsResult.Margin = new System.Windows.Forms.Padding(0);
            this.TabsResult.Name = "TabsResult";
            this.TabsResult.Padding = new System.Drawing.Point(0, 0);
            this.TabsResult.SelectedIndex = 0;
            this.TabsResult.Size = new System.Drawing.Size(559, 577);
            this.TabsResult.TabIndex = 1;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.txtConsole);
            this.tabOutput.Location = new System.Drawing.Point(4, 26);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(0);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(551, 547);
            this.tabOutput.TabIndex = 0;
            this.tabOutput.Text = "Output";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(551, 547);
            this.txtConsole.TabIndex = 2;
            this.txtConsole.WordWrap = false;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.PreViewBrowser);
            this.tabPreview.Location = new System.Drawing.Point(4, 26);
            this.tabPreview.Margin = new System.Windows.Forms.Padding(0);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Size = new System.Drawing.Size(551, 547);
            this.tabPreview.TabIndex = 1;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // PreViewBrowser
            // 
            this.PreViewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreViewBrowser.IsWebBrowserContextMenuEnabled = false;
            this.PreViewBrowser.Location = new System.Drawing.Point(0, 0);
            this.PreViewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreViewBrowser.Name = "PreViewBrowser";
            this.PreViewBrowser.Size = new System.Drawing.Size(551, 547);
            this.PreViewBrowser.TabIndex = 2;
            this.PreViewBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.PreViewBrowser_Navigating);
            this.PreViewBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.PreViewBrowser_NewWindow);
            // 
            // tabRequest
            // 
            this.tabRequest.Controls.Add(this.btnRunRequest);
            this.tabRequest.Controls.Add(this.lblRequestContent);
            this.tabRequest.Controls.Add(this.txtRequestContent);
            this.tabRequest.Controls.Add(this.btnSaveRequest);
            this.tabRequest.Controls.Add(this.label2);
            this.tabRequest.Controls.Add(this.txtRequestHeaders);
            this.tabRequest.Controls.Add(this.txtRequestUrl);
            this.tabRequest.Controls.Add(this.lblUrl);
            this.tabRequest.Controls.Add(this.txtHttpMethod);
            this.tabRequest.Location = new System.Drawing.Point(4, 26);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequest.Size = new System.Drawing.Size(551, 547);
            this.tabRequest.TabIndex = 3;
            this.tabRequest.Text = "Request";
            this.tabRequest.UseVisualStyleBackColor = true;
            // 
            // lblRequestContent
            // 
            this.lblRequestContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRequestContent.Location = new System.Drawing.Point(4, 333);
            this.lblRequestContent.Name = "lblRequestContent";
            this.lblRequestContent.Size = new System.Drawing.Size(130, 20);
            this.lblRequestContent.TabIndex = 7;
            this.lblRequestContent.Text = "Content:";
            this.lblRequestContent.UseCompatibleTextRendering = true;
            // 
            // txtRequestContent
            // 
            this.txtRequestContent.AcceptsReturn = true;
            this.txtRequestContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestContent.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestContent.Location = new System.Drawing.Point(5, 356);
            this.txtRequestContent.Multiline = true;
            this.txtRequestContent.Name = "txtRequestContent";
            this.txtRequestContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestContent.Size = new System.Drawing.Size(538, 143);
            this.txtRequestContent.TabIndex = 6;
            // 
            // btnSaveRequest
            // 
            this.btnSaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveRequest.Location = new System.Drawing.Point(5, 512);
            this.btnSaveRequest.Name = "btnSaveRequest";
            this.btnSaveRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRequest.TabIndex = 5;
            this.btnSaveRequest.Text = "&Save";
            this.btnSaveRequest.UseVisualStyleBackColor = false;
            this.btnSaveRequest.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Headers:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtRequestHeaders
            // 
            this.txtRequestHeaders.AcceptsReturn = true;
            this.txtRequestHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestHeaders.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestHeaders.Location = new System.Drawing.Point(6, 115);
            this.txtRequestHeaders.Multiline = true;
            this.txtRequestHeaders.Name = "txtRequestHeaders";
            this.txtRequestHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestHeaders.Size = new System.Drawing.Size(538, 203);
            this.txtRequestHeaders.TabIndex = 3;
            // 
            // txtRequestUrl
            // 
            this.txtRequestUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestUrl.Location = new System.Drawing.Point(6, 60);
            this.txtRequestUrl.Name = "txtRequestUrl";
            this.txtRequestUrl.Size = new System.Drawing.Size(537, 23);
            this.txtRequestUrl.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(3, 40);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(45, 20);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = " Url:";
            this.lblUrl.UseCompatibleTextRendering = true;
            // 
            // txtHttpMethod
            // 
            this.txtHttpMethod.FormattingEnabled = true;
            this.txtHttpMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "HEAD",
            "TRACE",
            "OPTIONS",
            "PATCH"});
            this.txtHttpMethod.Location = new System.Drawing.Point(6, 10);
            this.txtHttpMethod.Name = "txtHttpMethod";
            this.txtHttpMethod.Size = new System.Drawing.Size(152, 23);
            this.txtHttpMethod.TabIndex = 0;
            this.txtHttpMethod.Text = "GET";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.OptionsPropertyGrid);
            this.tabOptions.Location = new System.Drawing.Point(4, 26);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(551, 547);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // OptionsPropertyGrid
            // 
            this.OptionsPropertyGrid.BackColor = System.Drawing.Color.White;
            this.OptionsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPropertyGrid.HelpBackColor = System.Drawing.Color.White;
            this.OptionsPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.OptionsPropertyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsPropertyGrid.Name = "OptionsPropertyGrid";
            this.OptionsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.OptionsPropertyGrid.Size = new System.Drawing.Size(551, 547);
            this.OptionsPropertyGrid.TabIndex = 1;
            this.OptionsPropertyGrid.ToolbarVisible = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(992, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnRecentSessions,
            this.btnEditFile,
            this.btnClose,
            this.toolStripSeparator10,
            this.btnCapture,
            this.toolStripSeparator2,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(158, 22);
            this.btnOpen.Text = "&Open Session";
            this.btnOpen.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnRecentSessions
            // 
            this.btnRecentSessions.DropDown = this.RecentFilesContextMenu;
            this.btnRecentSessions.Name = "btnRecentSessions";
            this.btnRecentSessions.Size = new System.Drawing.Size(158, 22);
            this.btnRecentSessions.Text = "Recent Sessions";
            // 
            // RecentFilesContextMenu
            // 
            this.RecentFilesContextMenu.Name = "RecentFilesContextMenu";
            this.RecentFilesContextMenu.OwnerItem = this.btnRecentSessions;
            this.RecentFilesContextMenu.Size = new System.Drawing.Size(61, 4);
            this.RecentFilesContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.AddRecentFiles);
            // 
            // tbOpen
            // 
            this.tbOpen.DropDown = this.RecentFilesContextMenu;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(110, 22);
            this.tbOpen.Text = "Open Session";
            this.tbOpen.ButtonClick += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnEditFile
            // 
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(158, 22);
            this.btnEditFile.Text = "&Edit Session File";
            this.btnEditFile.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 22);
            this.btnClose.Text = "C&lose Session";
            this.btnClose.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(155, 6);
            // 
            // btnCapture
            // 
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(158, 22);
            this.btnCapture.Text = "&Capture Session";
            this.btnCapture.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 22);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnStop,
            this.btnExport,
            this.btnCharts});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // btnStart
            // 
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 22);
            this.btnStart.Text = "&Start";
            this.btnStart.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnStop
            // 
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 22);
            this.btnStop.Text = "S&top";
            this.btnStop.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnExport
            // 
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportXml,
            this.btnExportJson,
            this.btnExportHtml});
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 22);
            this.btnExport.Text = "E&xport";
            // 
            // btnExportXml
            // 
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(101, 22);
            this.btnExportXml.Text = "Xml";
            this.btnExportXml.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(101, 22);
            this.btnExportJson.Text = "Json";
            this.btnExportJson.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnExportHtml
            // 
            this.btnExportHtml.Name = "btnExportHtml";
            this.btnExportHtml.Size = new System.Drawing.Size(101, 22);
            this.btnExportHtml.Text = "Html";
            this.btnExportHtml.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRequestsPerSecondChart,
            this.btnTimeTakenPerUrlChart});
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(108, 22);
            this.btnCharts.Text = "Charts";
            this.btnCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // btnRequestsPerSecondChart
            // 
            this.btnRequestsPerSecondChart.Name = "btnRequestsPerSecondChart";
            this.btnRequestsPerSecondChart.Size = new System.Drawing.Size(183, 22);
            this.btnRequestsPerSecondChart.Text = "Requests per Second";
            // 
            // btnTimeTakenPerUrlChart
            // 
            this.btnTimeTakenPerUrlChart.Name = "btnTimeTakenPerUrlChart";
            this.btnTimeTakenPerUrlChart.Size = new System.Drawing.Size(183, 22);
            this.btnTimeTakenPerUrlChart.Text = "Time taken per URL";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGotoWebSite,
            this.toolStripSeparator7,
            this.btnGotoRegistration,
            this.btnRegistration,
            this.toolStripSeparator4,
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnGotoWebSite
            // 
            this.btnGotoWebSite.Name = "btnGotoWebSite";
            this.btnGotoWebSite.Size = new System.Drawing.Size(189, 22);
            this.btnGotoWebSite.Text = "WebSurge Web Site";
            this.btnGotoWebSite.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(186, 6);
            // 
            // btnGotoRegistration
            // 
            this.btnGotoRegistration.Name = "btnGotoRegistration";
            this.btnGotoRegistration.Size = new System.Drawing.Size(189, 22);
            this.btnGotoRegistration.Text = "Register WebSurge";
            this.btnGotoRegistration.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(189, 22);
            this.btnRegistration.Text = "Enter Registration Key";
            this.btnRegistration.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(189, 22);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOpen,
            this.tbEditFile,
            this.tbCapture,
            this.toolStripSeparator1,
            this.tbStart,
            this.tbStop,
            this.toolStripSeparator3,
            this.tbExport,
            this.tbCharts});
            this.MainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainToolStrip.Location = new System.Drawing.Point(3, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(579, 25);
            this.MainToolStrip.TabIndex = 0;
            // 
            // tbEditFile
            // 
            this.tbEditFile.Image = ((System.Drawing.Image)(resources.GetObject("tbEditFile.Image")));
            this.tbEditFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEditFile.Name = "tbEditFile";
            this.tbEditFile.Size = new System.Drawing.Size(89, 22);
            this.tbEditFile.Text = "Edit Session";
            this.tbEditFile.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbCapture
            // 
            this.tbCapture.Image = ((System.Drawing.Image)(resources.GetObject("tbCapture.Image")));
            this.tbCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCapture.Name = "tbCapture";
            this.tbCapture.Size = new System.Drawing.Size(69, 22);
            this.tbCapture.Text = "Capture";
            this.tbCapture.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbStart
            // 
            this.tbStart.Image = ((System.Drawing.Image)(resources.GetObject("tbStart.Image")));
            this.tbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(51, 22);
            this.tbStart.Text = "Start";
            this.tbStart.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbStop
            // 
            this.tbStop.Image = ((System.Drawing.Image)(resources.GetObject("tbStop.Image")));
            this.tbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(51, 22);
            this.tbStop.Text = "Stop";
            this.tbStop.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbExport
            // 
            this.tbExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbExportXml,
            this.tbExportJson,
            this.tbExportHtml});
            this.tbExport.Image = ((System.Drawing.Image)(resources.GetObject("tbExport.Image")));
            this.tbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(112, 22);
            this.tbExport.Text = "Export Results";
            // 
            // tbExportXml
            // 
            this.tbExportXml.Name = "tbExportXml";
            this.tbExportXml.Size = new System.Drawing.Size(101, 22);
            this.tbExportXml.Text = "Xml";
            this.tbExportXml.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbExportJson
            // 
            this.tbExportJson.Name = "tbExportJson";
            this.tbExportJson.Size = new System.Drawing.Size(101, 22);
            this.tbExportJson.Text = "Json";
            this.tbExportJson.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbExportHtml
            // 
            this.tbExportHtml.Name = "tbExportHtml";
            this.tbExportHtml.Size = new System.Drawing.Size(101, 22);
            this.tbExportHtml.Text = "Html";
            this.tbExportHtml.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // tbCharts
            // 
            this.tbCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRequestPerSecondChart,
            this.tbTimeTakenPerUrlChart});
            this.tbCharts.Image = ((System.Drawing.Image)(resources.GetObject("tbCharts.Image")));
            this.tbCharts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCharts.Name = "tbCharts";
            this.tbCharts.Size = new System.Drawing.Size(73, 22);
            this.tbCharts.Text = "Charts";
            this.tbCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbRequestPerSecondChart
            // 
            this.tbRequestPerSecondChart.Name = "tbRequestPerSecondChart";
            this.tbRequestPerSecondChart.Size = new System.Drawing.Size(183, 22);
            this.tbRequestPerSecondChart.Text = "Requests per Second";
            this.tbRequestPerSecondChart.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbTimeTakenPerUrlChart
            // 
            this.tbTimeTakenPerUrlChart.Name = "tbTimeTakenPerUrlChart";
            this.tbTimeTakenPerUrlChart.Size = new System.Drawing.Size(183, 22);
            this.tbTimeTakenPerUrlChart.Text = "Time taken per URL";
            // 
            // OptionsToolStrip
            // 
            this.OptionsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.OptionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbtxtTimeToRun,
            this.toolStripLabel3,
            this.toolStripLabel1,
            this.tbtxtThreads,
            this.toolStripSeparator5,
            this.tbNoProgressEvents});
            this.OptionsToolStrip.Location = new System.Drawing.Point(3, 49);
            this.OptionsToolStrip.Name = "OptionsToolStrip";
            this.OptionsToolStrip.Size = new System.Drawing.Size(242, 25);
            this.OptionsToolStrip.TabIndex = 2;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "Time:";
            // 
            // tbtxtTimeToRun
            // 
            this.tbtxtTimeToRun.Name = "tbtxtTimeToRun";
            this.tbtxtTimeToRun.Size = new System.Drawing.Size(40, 25);
            this.tbtxtTimeToRun.Text = "30";
            this.tbtxtTimeToRun.ToolTipText = "Duration of the test to run in seconds.";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel3.Text = "secs   ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Threads:";
            // 
            // tbtxtThreads
            // 
            this.tbtxtThreads.Name = "tbtxtThreads";
            this.tbtxtThreads.Size = new System.Drawing.Size(30, 25);
            this.tbtxtThreads.Text = "2";
            this.tbtxtThreads.ToolTipText = "The number of sessions to run simultaneously";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tbNoProgressEvents
            // 
            this.tbNoProgressEvents.CheckOnClick = true;
            this.tbNoProgressEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNoProgressEvents.Image = ((System.Drawing.Image)(resources.GetObject("tbNoProgressEvents.Image")));
            this.tbNoProgressEvents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNoProgressEvents.Name = "tbNoProgressEvents";
            this.tbNoProgressEvents.Size = new System.Drawing.Size(23, 22);
            this.tbNoProgressEvents.Text = "No Console";
            this.tbNoProgressEvents.ToolTipText = "Don\'t show progress info - faster, can create more requests.";
            this.tbNoProgressEvents.CheckedChanged += new System.EventHandler(this.tbNoProgressEvents_CheckedChanged);
            // 
            // btnRunRequest
            // 
            this.btnRunRequest.Location = new System.Drawing.Point(86, 512);
            this.btnRunRequest.Name = "btnRunRequest";
            this.btnRunRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRunRequest.TabIndex = 8;
            this.btnRunRequest.Text = "Run";
            this.btnRunRequest.UseVisualStyleBackColor = true;
            this.btnRunRequest.Click += new System.EventHandler(this.ButtonHandler_Click);
            // 
            // StressTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "StressTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "West Wind WebSurge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StressTestForm_FormClosed);
            this.Load += new System.EventHandler(this.StressTestForm_Load);
            this.Shown += new System.EventHandler(this.StressTestForm_Shown);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.BottomSplitContainer.Panel1.ResumeLayout(false);
            this.BottomSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).EndInit();
            this.BottomSplitContainer.ResumeLayout(false);
            this.TabSessions.ResumeLayout(false);
            this.tabSession.ResumeLayout(false);
            this.tabSession.PerformLayout();
            this.SessionToolStrip.ResumeLayout(false);
            this.SessionToolStrip.PerformLayout();
            this.RequestContextMenu.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            this.ResultContextMenu.ResumeLayout(false);
            this.TabsResult.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tabOutput.PerformLayout();
            this.tabPreview.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabRequest.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.OptionsToolStrip.ResumeLayout(false);
            this.OptionsToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        //private System.Windows.Forms.SplitContainer HorizontalSplitContainer;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtProcessingTime;
        public System.Windows.Forms.SplitContainer BottomSplitContainer;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFilename;
        private System.Windows.Forms.TabControl TabsResult;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.WebBrowser PreViewBrowser;
        private System.Windows.Forms.ToolStripButton tbCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbStart;
        private System.Windows.Forms.ToolStripButton tbStop;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnEditFile;
        private System.Windows.Forms.ToolStripMenuItem btnCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStart;
        private System.Windows.Forms.ToolStripMenuItem btnStop;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnExportXml;
        private System.Windows.Forms.ToolStripMenuItem btnExportJson;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton tbExport;
        private System.Windows.Forms.ToolStripMenuItem tbExportXml;
        private System.Windows.Forms.ToolStripMenuItem tbExportJson;
        private System.Windows.Forms.ToolStripMenuItem btnGotoWebSite;
        private System.Windows.Forms.ToolStripMenuItem btnGotoRegistration;
        private System.Windows.Forms.ToolStripMenuItem btnRegistration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnExportHtml;
        private System.Windows.Forms.ToolStripMenuItem tbExportHtml;
        private System.Windows.Forms.ToolStrip OptionsToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbtxtThreads;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbtxtTimeToRun;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbNoProgressEvents;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.PropertyGrid OptionsPropertyGrid;
        private System.Windows.Forms.TabControl TabSessions;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.ListView ListResults;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Request;
        private System.Windows.Forms.ColumnHeader ErrorMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListDisplayMode;
        private System.Windows.Forms.ListView ListRequests;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip RequestContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tbDeleteRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tbSaveAllRequests;
        private System.Windows.Forms.ToolStripMenuItem tbAddRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ContextMenuStrip ResultContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tbResultCharts;
        private System.Windows.Forms.ToolStripMenuItem tbRequestsPerSecondChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tbTimeTakenPerUrl;
        private System.Windows.Forms.ToolStripMenuItem btnCharts;
        private System.Windows.Forms.ToolStripMenuItem btnRequestsPerSecondChart;
        private System.Windows.Forms.ToolStripMenuItem btnTimeTakenPerUrlChart;
        private System.Windows.Forms.ToolStripSplitButton tbCharts;
        private System.Windows.Forms.ToolStripMenuItem tbRequestPerSecondChart;
        private System.Windows.Forms.ToolStripMenuItem tbTimeTakenPerUrlChart;
        private System.Windows.Forms.TabPage tabRequest;
        private System.Windows.Forms.Button btnSaveRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestHeaders;
        private System.Windows.Forms.TextBox txtRequestUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ComboBox txtHttpMethod;
        private System.Windows.Forms.ToolStripMenuItem tbEditRequest;
        private System.Windows.Forms.Label lblRequestContent;
        private System.Windows.Forms.TextBox txtRequestContent;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStrip SessionToolStrip;
        private System.Windows.Forms.ToolStripButton tbAddRequest2;
        private System.Windows.Forms.ToolStripButton tbEditRequest2;
        private System.Windows.Forms.ToolStripButton tbDeleteRequest2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tbSaveAllRequests2;
        private System.Windows.Forms.ToolStripMenuItem btnRecentSessions;
        private System.Windows.Forms.ContextMenuStrip RecentFilesContextMenu;
        private System.Windows.Forms.ToolStripButton tbEditFile;
        private System.Windows.Forms.ToolStripSplitButton tbOpen;
        private System.Windows.Forms.Button btnRunRequest;
    }
}
