namespace WebSurge
{
    partial class ImportResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportResultsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbImport = new System.Windows.Forms.ToolStripSplitButton();
            this.tbImportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.tbImportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tbImportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.importedFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.includedFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSplitContainer)).BeginInit();
            this.lblSplitContainer.Panel1.SuspendLayout();
            this.lblSplitContainer.Panel2.SuspendLayout();
            this.lblSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setsSplitContainer)).BeginInit();
            this.setsSplitContainer.Panel1.SuspendLayout();
            this.setsSplitContainer.Panel2.SuspendLayout();
            this.setsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbImport
            // 
            this.tbImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbImportRaw,
            this.tbImportJson,
            this.tbImportXml});
            this.tbImport.Image = ((System.Drawing.Image)(resources.GetObject("tbImport.Image")));
            this.tbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbImport.Name = "tbImport";
            this.tbImport.Size = new System.Drawing.Size(115, 22);
            this.tbImport.Text = "Import Results";
            this.tbImport.ToolTipText = "Import Results";
            // 
            // tbImportRaw
            // 
            this.tbImportRaw.Enabled = false;
            this.tbImportRaw.Name = "tbImportRaw";
            this.tbImportRaw.Size = new System.Drawing.Size(128, 22);
            this.tbImportRaw.Text = "WebSurge";
            this.tbImportRaw.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // tbImportJson
            // 
            this.tbImportJson.Name = "tbImportJson";
            this.tbImportJson.Size = new System.Drawing.Size(128, 22);
            this.tbImportJson.Text = "Json";
            this.tbImportJson.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // tbImportXml
            // 
            this.tbImportXml.Enabled = false;
            this.tbImportXml.Name = "tbImportXml";
            this.tbImportXml.Size = new System.Drawing.Size(128, 22);
            this.tbImportXml.Text = "Xml";
            this.tbImportXml.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // lblSplitContainer
            // 
            this.lblSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSplitContainer.IsSplitterFixed = true;
            this.lblSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.lblSplitContainer.Name = "lblSplitContainer";
            // 
            // lblSplitContainer.Panel1
            // 
            this.lblSplitContainer.Panel1.Controls.Add(this.label1);
            // 
            // lblSplitContainer.Panel2
            // 
            this.lblSplitContainer.Panel2.Controls.Add(this.label2);
            this.lblSplitContainer.Size = new System.Drawing.Size(784, 29);
            this.lblSplitContainer.SplitterDistance = 392;
            this.lblSplitContainer.SplitterWidth = 1;
            this.lblSplitContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imported Result Sets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Included Result Sets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setsSplitContainer
            // 
            this.setsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.setsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setsSplitContainer.IsSplitterFixed = true;
            this.setsSplitContainer.Location = new System.Drawing.Point(0, 54);
            this.setsSplitContainer.Name = "setsSplitContainer";
            // 
            // setsSplitContainer.Panel1
            // 
            this.setsSplitContainer.Panel1.Controls.Add(this.importedFlowPanel);
            // 
            // setsSplitContainer.Panel2
            // 
            this.setsSplitContainer.Panel2.Controls.Add(this.includedFlowPanel);
            this.setsSplitContainer.Size = new System.Drawing.Size(784, 507);
            this.setsSplitContainer.SplitterDistance = 392;
            this.setsSplitContainer.SplitterWidth = 1;
            this.setsSplitContainer.TabIndex = 3;
            // 
            // importedFlowPanel
            // 
            this.importedFlowPanel.AutoScroll = true;
            this.importedFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importedFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.importedFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.importedFlowPanel.Name = "importedFlowPanel";
            this.importedFlowPanel.Size = new System.Drawing.Size(388, 503);
            this.importedFlowPanel.TabIndex = 0;
            // 
            // includedFlowPanel
            // 
            this.includedFlowPanel.AutoScroll = true;
            this.includedFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.includedFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.includedFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.includedFlowPanel.Name = "includedFlowPanel";
            this.includedFlowPanel.Size = new System.Drawing.Size(387, 503);
            this.includedFlowPanel.TabIndex = 1;
            this.includedFlowPanel.WrapContents = false;
            // 
            // ImportResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.setsSplitContainer);
            this.Controls.Add(this.lblSplitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ImportResultsForm";
            this.Text = "Import Results";
            this.Shown += new System.EventHandler(this.ImportResultsForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lblSplitContainer.Panel1.ResumeLayout(false);
            this.lblSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblSplitContainer)).EndInit();
            this.lblSplitContainer.ResumeLayout(false);
            this.setsSplitContainer.Panel1.ResumeLayout(false);
            this.setsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setsSplitContainer)).EndInit();
            this.setsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tbImport;
        private System.Windows.Forms.ToolStripMenuItem tbImportRaw;
        private System.Windows.Forms.ToolStripMenuItem tbImportJson;
        private System.Windows.Forms.ToolStripMenuItem tbImportXml;
        private System.Windows.Forms.SplitContainer lblSplitContainer;
        private System.Windows.Forms.SplitContainer setsSplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel importedFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel includedFlowPanel;
    }
}