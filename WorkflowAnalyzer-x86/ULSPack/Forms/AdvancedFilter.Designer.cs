namespace ULSPack.Forms
{
    partial class AdvancedFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedFilter));
            this.ULSGridView = new System.Windows.Forms.DataGridView();
            this.Field = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ULSGridView)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ULSGridView
            // 
            this.ULSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ULSGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Field,
            this.Operation,
            this.Query});
            this.ULSGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ULSGridView.Location = new System.Drawing.Point(0, 0);
            this.ULSGridView.Name = "ULSGridView";
            this.ULSGridView.RowTemplate.Height = 24;
            this.ULSGridView.Size = new System.Drawing.Size(545, 275);
            this.ULSGridView.TabIndex = 0;
            // 
            // Field
            // 
            this.Field.HeaderText = "Field";
            this.Field.Items.AddRange(new object[] {
            "All",
            "TimeStamp",
            "Process",
            "Thread",
            "Product",
            "Category",
            "EventID",
            "Level",
            "Message",
            "Correlation"});
            this.Field.Name = "Field";
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation";
            this.Operation.Items.AddRange(new object[] {
            "Contains",
            "NotContains",
            "Equals",
            "NotEquals",
            "RegexMatch"});
            this.Operation.Name = "Operation";
            // 
            // Query
            // 
            this.Query.HeaderText = "Query";
            this.Query.Name = "Query";
            this.Query.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Query.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Query.Width = 300;
            // 
            // TopPanel
            // 
            this.TopPanel.AutoScroll = true;
            this.TopPanel.Controls.Add(this.ULSGridView);
            this.TopPanel.Location = new System.Drawing.Point(12, 12);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(545, 275);
            this.TopPanel.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(401, 293);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(482, 293);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AdvancedFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedFilter";
            this.Text = "Advanced Filter";
            ((System.ComponentModel.ISupportInitialize)(this.ULSGridView)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ULSGridView;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Field;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
    }
}