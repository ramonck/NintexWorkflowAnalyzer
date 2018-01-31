namespace ULSPack.Controls
{
    partial class ULSLogEntriesGridControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ULSLogEntriesGridControl));
            this.LogEntriesGrid = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.LogEntriesGrid)).BeginInit();
            this.FilterToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogEntriesGrid
            // 
            this.LogEntriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogEntriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.Process,
            this.Thread,
            this.Product,
            this.Category,
            this.EventID,
            this.Level,
            this.Message,
            this.Correlation});
            this.LogEntriesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogEntriesGrid.Location = new System.Drawing.Point(0, 32);
            this.LogEntriesGrid.Name = "LogEntriesGrid";
            this.LogEntriesGrid.ReadOnly = true;
            this.LogEntriesGrid.RowTemplate.Height = 24;
            this.LogEntriesGrid.Size = new System.Drawing.Size(0, 0);
            this.LogEntriesGrid.TabIndex = 0;
            this.LogEntriesGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LogEntriesGrid_MouseDoubleClick);
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // Thread
            // 
            this.Thread.HeaderText = "Thread";
            this.Thread.Name = "Thread";
            this.Thread.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // EventID
            // 
            this.EventID.HeaderText = "EventID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Correlation
            // 
            this.Correlation.HeaderText = "Correlation";
            this.Correlation.Name = "Correlation";
            this.Correlation.ReadOnly = true;
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
            this.FilterToolStrip.Size = new System.Drawing.Size(0, 32);
            this.FilterToolStrip.TabIndex = 1;
            this.FilterToolStrip.Text = "toolStrip1";
            // 
            // ResetFiltering
            // 
            this.ResetFiltering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetFiltering.Image = ((System.Drawing.Image)(resources.GetObject("ResetFiltering.Image")));
            this.ResetFiltering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetFiltering.Name = "ResetFiltering";
            this.ResetFiltering.Size = new System.Drawing.Size(23, 20);
            this.ResetFiltering.Text = "Reset Filters";
            this.ResetFiltering.ToolTipText = "Reset Filters";
            this.ResetFiltering.Click += new System.EventHandler(this.ResetFiltering_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(61, 20);
            this.ProcessLabel.Text = "Process:";
            // 
            // ProcessFilter
            // 
            this.ProcessFilter.Name = "ProcessFilter";
            this.ProcessFilter.Size = new System.Drawing.Size(121, 28);
            this.ProcessFilter.ToolTipText = "Process Filter";
            this.ProcessFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 20);
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryFilter
            // 
            this.CategoryFilter.Name = "CategoryFilter";
            this.CategoryFilter.Size = new System.Drawing.Size(121, 28);
            this.CategoryFilter.ToolTipText = "Category Filter";
            this.CategoryFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(46, 20);
            this.LevelLabel.Text = "Level:";
            // 
            // LevelFilter
            // 
            this.LevelFilter.Name = "LevelFilter";
            this.LevelFilter.Size = new System.Drawing.Size(121, 28);
            this.LevelFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // CorrelationLabel
            // 
            this.CorrelationLabel.Name = "CorrelationLabel";
            this.CorrelationLabel.Size = new System.Drawing.Size(86, 20);
            this.CorrelationLabel.Text = "Correlation:";
            // 
            // CorrelationFilter
            // 
            this.CorrelationFilter.Name = "CorrelationFilter";
            this.CorrelationFilter.Size = new System.Drawing.Size(121, 28);
            this.CorrelationFilter.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(78, 20);
            this.SearchLabel.Text = "Search All:";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(130, 27);
            this.SearchTextbox.ToolTipText = "Search all fields";
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(23, 20);
            this.SearchButton.Text = "Search All Fields (Case Insensitive)";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AdvancedQueryButton
            // 
            this.AdvancedQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AdvancedQueryButton.Image = ((System.Drawing.Image)(resources.GetObject("AdvancedQueryButton.Image")));
            this.AdvancedQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdvancedQueryButton.Name = "AdvancedQueryButton";
            this.AdvancedQueryButton.Size = new System.Drawing.Size(122, 24);
            this.AdvancedQueryButton.Text = "Advanced Query";
            this.AdvancedQueryButton.Click += new System.EventHandler(this.AdvancedQueryButton_Click);
            // 
            // ULSLogEntriesGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LogEntriesGrid);
            this.Controls.Add(this.FilterToolStrip);
            this.Name = "ULSLogEntriesGridControl";
            this.Size = new System.Drawing.Size(0, 32);
            this.Load += new System.EventHandler(this.ULSLogEntriesGridControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogEntriesGrid)).EndInit();
            this.FilterToolStrip.ResumeLayout(false);
            this.FilterToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LogEntriesGrid;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlation;
    }
}
