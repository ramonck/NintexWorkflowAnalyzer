namespace ULSPack.Controls
{
    partial class ULSLogEntriesGridControlV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ULSLogEntriesGridControlV2));
            this.FilterToolStrip = new System.Windows.Forms.ToolStrip();
            this.ResetFiltering = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ProcessLabel = new System.Windows.Forms.ToolStripLabel();
            this.ProcessFilter = new System.Windows.Forms.ToolStripComboBox();
            this.CategoryLabel = new System.Windows.Forms.ToolStripLabel();
            this.CategoryFilter = new System.Windows.Forms.ToolStripComboBox();
            this.LevelLabel = new System.Windows.Forms.ToolStripLabel();
            this.LevelFilter = new System.Windows.Forms.ToolStripComboBox();
            this.CorrelationLabel = new System.Windows.Forms.ToolStripLabel();
            this.CorrelationFilter = new System.Windows.Forms.ToolStripComboBox();
            this.SearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.AdvancedQueryButton = new System.Windows.Forms.ToolStripButton();
            this.WpfAdapter = new System.Windows.Forms.Integration.ElementHost();
            this.TopLevelContainer = new System.Windows.Forms.SplitContainer();
            this.MessagePreviewTextbox = new System.Windows.Forms.RichTextBox();
            this.FilterToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLevelContainer)).BeginInit();
            this.TopLevelContainer.Panel1.SuspendLayout();
            this.TopLevelContainer.Panel2.SuspendLayout();
            this.TopLevelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterToolStrip
            // 
            this.FilterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetFiltering,
            this.toolStripSeparator1,
            this.ProcessLabel,
            this.ProcessFilter,
            this.CategoryLabel,
            this.CategoryFilter,
            this.LevelLabel,
            this.LevelFilter,
            this.CorrelationLabel,
            this.CorrelationFilter,
            this.SearchLabel,
            this.SearchTextbox,
            this.SearchButton,
            this.AdvancedQueryButton});
            this.FilterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FilterToolStrip.Name = "FilterToolStrip";
            this.FilterToolStrip.Size = new System.Drawing.Size(1131, 25);
            this.FilterToolStrip.TabIndex = 1;
            this.FilterToolStrip.Text = "toolStrip1";
            // 
            // ResetFiltering
            // 
            this.ResetFiltering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetFiltering.Image = ((System.Drawing.Image)(resources.GetObject("ResetFiltering.Image")));
            this.ResetFiltering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetFiltering.Name = "ResetFiltering";
            this.ResetFiltering.Size = new System.Drawing.Size(23, 22);
            this.ResetFiltering.Text = "Reset Filters";
            this.ResetFiltering.ToolTipText = "Reset Filters";
            this.ResetFiltering.Click += new System.EventHandler(this.ResetFiltering_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(50, 22);
            this.ProcessLabel.Text = "Process:";
            // 
            // ProcessFilter
            // 
            this.ProcessFilter.Name = "ProcessFilter";
            this.ProcessFilter.Size = new System.Drawing.Size(121, 25);
            this.ProcessFilter.ToolTipText = "Process Filter";
            this.ProcessFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(58, 22);
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryFilter
            // 
            this.CategoryFilter.Name = "CategoryFilter";
            this.CategoryFilter.Size = new System.Drawing.Size(121, 25);
            this.CategoryFilter.ToolTipText = "Category Filter";
            this.CategoryFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(37, 22);
            this.LevelLabel.Text = "Level:";
            // 
            // LevelFilter
            // 
            this.LevelFilter.Name = "LevelFilter";
            this.LevelFilter.Size = new System.Drawing.Size(121, 25);
            this.LevelFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // CorrelationLabel
            // 
            this.CorrelationLabel.Name = "CorrelationLabel";
            this.CorrelationLabel.Size = new System.Drawing.Size(69, 22);
            this.CorrelationLabel.Text = "Correlation:";
            // 
            // CorrelationFilter
            // 
            this.CorrelationFilter.Name = "CorrelationFilter";
            this.CorrelationFilter.Size = new System.Drawing.Size(121, 25);
            this.CorrelationFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(62, 22);
            this.SearchLabel.Text = "Search All:";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(130, 25);
            this.SearchTextbox.ToolTipText = "Search all fields";
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(23, 22);
            this.SearchButton.Text = "Search All Fields (Case Insensitive)";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AdvancedQueryButton
            // 
            this.AdvancedQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AdvancedQueryButton.Image = ((System.Drawing.Image)(resources.GetObject("AdvancedQueryButton.Image")));
            this.AdvancedQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdvancedQueryButton.Name = "AdvancedQueryButton";
            this.AdvancedQueryButton.Size = new System.Drawing.Size(99, 22);
            this.AdvancedQueryButton.Text = "Advanced Query";
            this.AdvancedQueryButton.Click += new System.EventHandler(this.AdvancedQueryButton_Click);
            // 
            // WpfAdapter
            // 
            this.WpfAdapter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WpfAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WpfAdapter.Location = new System.Drawing.Point(0, 0);
            this.WpfAdapter.Name = "WpfAdapter";
            this.WpfAdapter.Size = new System.Drawing.Size(1131, 433);
            this.WpfAdapter.TabIndex = 2;
            this.WpfAdapter.Text = "elementHost1";
            this.WpfAdapter.Child = null;
            // 
            // TopLevelContainer
            // 
            this.TopLevelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLevelContainer.Location = new System.Drawing.Point(0, 25);
            this.TopLevelContainer.Name = "TopLevelContainer";
            this.TopLevelContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TopLevelContainer.Panel1
            // 
            this.TopLevelContainer.Panel1.Controls.Add(this.MessagePreviewTextbox);
            // 
            // TopLevelContainer.Panel2
            // 
            this.TopLevelContainer.Panel2.Controls.Add(this.WpfAdapter);
            this.TopLevelContainer.Size = new System.Drawing.Size(1131, 604);
            this.TopLevelContainer.SplitterDistance = 167;
            this.TopLevelContainer.TabIndex = 3;
            // 
            // MessagePreviewTextbox
            // 
            this.MessagePreviewTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePreviewTextbox.Location = new System.Drawing.Point(0, 0);
            this.MessagePreviewTextbox.Name = "MessagePreviewTextbox";
            this.MessagePreviewTextbox.Size = new System.Drawing.Size(1131, 167);
            this.MessagePreviewTextbox.TabIndex = 0;
            this.MessagePreviewTextbox.Text = "";
            // 
            // ULSLogEntriesGridControlV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TopLevelContainer);
            this.Controls.Add(this.FilterToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ULSLogEntriesGridControlV2";
            this.Size = new System.Drawing.Size(1131, 629);
            this.Load += new System.EventHandler(this.ULSLogEntriesGridControl_Load);
            this.FilterToolStrip.ResumeLayout(false);
            this.FilterToolStrip.PerformLayout();
            this.TopLevelContainer.Panel1.ResumeLayout(false);
            this.TopLevelContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLevelContainer)).EndInit();
            this.TopLevelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip FilterToolStrip;
        private System.Windows.Forms.ToolStripButton ResetFiltering;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox ProcessFilter;
        private System.Windows.Forms.ToolStripComboBox CategoryFilter;
        private System.Windows.Forms.ToolStripLabel ProcessLabel;
        private System.Windows.Forms.ToolStripLabel CategoryLabel;
        private System.Windows.Forms.ToolStripLabel LevelLabel;
        private System.Windows.Forms.ToolStripComboBox LevelFilter;
        private System.Windows.Forms.ToolStripLabel CorrelationLabel;
        private System.Windows.Forms.ToolStripComboBox CorrelationFilter;
        private System.Windows.Forms.ToolStripLabel SearchLabel;
        private System.Windows.Forms.ToolStripTextBox SearchTextbox;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton AdvancedQueryButton;
        private System.Windows.Forms.Integration.ElementHost WpfAdapter;
        private System.Windows.Forms.SplitContainer TopLevelContainer;
        private System.Windows.Forms.RichTextBox MessagePreviewTextbox;
    }
}
