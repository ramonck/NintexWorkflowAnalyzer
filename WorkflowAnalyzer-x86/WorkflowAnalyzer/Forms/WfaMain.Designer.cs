namespace WorkflowAnalyzer.Forms
{
    partial class WfaMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WfaMain));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphicalViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMainViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVariablesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkflowConfigurationViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExternalConfigurationViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePossibleIssuesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkflowPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularExpressionToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1152, 520);
            this.MainPanel.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphicalViewToolStripMenuItem,
            this.saveMainViewToolStripMenuItem,
            this.saveVariablesViewToolStripMenuItem,
            this.saveWorkflowConfigurationViewToolStripMenuItem,
            this.saveExternalConfigurationViewToolStripMenuItem,
            this.savePossibleIssuesViewToolStripMenuItem,
            this.saveWorkflowPreviewToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "E&xport";
            // 
            // saveGraphicalViewToolStripMenuItem
            // 
            this.saveGraphicalViewToolStripMenuItem.Name = "saveGraphicalViewToolStripMenuItem";
            this.saveGraphicalViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveGraphicalViewToolStripMenuItem.Text = "&Graphical View (*.png)";
            this.saveGraphicalViewToolStripMenuItem.Click += new System.EventHandler(this.saveGraphicalViewToolStripMenuItem1_Click);
            // 
            // saveMainViewToolStripMenuItem
            // 
            this.saveMainViewToolStripMenuItem.Name = "saveMainViewToolStripMenuItem";
            this.saveMainViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveMainViewToolStripMenuItem.Text = "&Actions (*.html)";
            this.saveMainViewToolStripMenuItem.Click += new System.EventHandler(this.saveActionViewToolStripMenuItem_Click);
            // 
            // saveVariablesViewToolStripMenuItem
            // 
            this.saveVariablesViewToolStripMenuItem.Name = "saveVariablesViewToolStripMenuItem";
            this.saveVariablesViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveVariablesViewToolStripMenuItem.Text = "&Variables (*.html)";
            this.saveVariablesViewToolStripMenuItem.Click += new System.EventHandler(this.saveVariablesViewToolStripMenuItem_Click);
            // 
            // saveWorkflowConfigurationViewToolStripMenuItem
            // 
            this.saveWorkflowConfigurationViewToolStripMenuItem.Name = "saveWorkflowConfigurationViewToolStripMenuItem";
            this.saveWorkflowConfigurationViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveWorkflowConfigurationViewToolStripMenuItem.Text = "&Parameters (*.html)";
            this.saveWorkflowConfigurationViewToolStripMenuItem.Click += new System.EventHandler(this.saveWorkflowConfigurationViewToolStripMenuItem_Click);
            // 
            // saveExternalConfigurationViewToolStripMenuItem
            // 
            this.saveExternalConfigurationViewToolStripMenuItem.Name = "saveExternalConfigurationViewToolStripMenuItem";
            this.saveExternalConfigurationViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveExternalConfigurationViewToolStripMenuItem.Text = "&External References (*.html)";
            this.saveExternalConfigurationViewToolStripMenuItem.Click += new System.EventHandler(this.saveExternalReferencesViewToolStripMenuItem_Click);
            // 
            // savePossibleIssuesViewToolStripMenuItem
            // 
            this.savePossibleIssuesViewToolStripMenuItem.Name = "savePossibleIssuesViewToolStripMenuItem";
            this.savePossibleIssuesViewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.savePossibleIssuesViewToolStripMenuItem.Text = "&Possible Issues  (*.html)";
            this.savePossibleIssuesViewToolStripMenuItem.Click += new System.EventHandler(this.savePossibleIssuesViewToolStripMenuItem_Click);
            // 
            // saveWorkflowPreviewToolStripMenuItem
            // 
            this.saveWorkflowPreviewToolStripMenuItem.Enabled = false;
            this.saveWorkflowPreviewToolStripMenuItem.Name = "saveWorkflowPreviewToolStripMenuItem";
            this.saveWorkflowPreviewToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveWorkflowPreviewToolStripMenuItem.Text = "&XML Editor Preview (*.png)";
            this.saveWorkflowPreviewToolStripMenuItem.Click += new System.EventHandler(this.saveWorkflowPreviewToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularExpressionToolToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // regularExpressionToolToolStripMenuItem
            // 
            this.regularExpressionToolToolStripMenuItem.Name = "regularExpressionToolToolStripMenuItem";
            this.regularExpressionToolToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.regularExpressionToolToolStripMenuItem.Text = "&Regular Expression Tool";
            this.regularExpressionToolToolStripMenuItem.Click += new System.EventHandler(this.regularExpressionToolToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.browseToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pluginsToolStripMenuItem.Text = "&Plugins";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.installToolStripMenuItem.Text = "&Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.browseToolStripMenuItem.Text = "&Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // WfaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 544);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WfaMain";
            this.Text = "Nintex Workflow Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGraphicalViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMainViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVariablesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkflowConfigurationViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExternalConfigurationViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePossibleIssuesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkflowPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularExpressionToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
    }
}

