namespace SupportPackage.Controls
{
    partial class NintexContentDatabaseControl
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
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.DataSource = new System.Windows.Forms.Label();
            this.EnableIncoming = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.DataSource);
            this.ParentPanel.Controls.Add(this.EnableIncoming);
            this.ParentPanel.Location = new System.Drawing.Point(3, 3);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(415, 60);
            this.ParentPanel.TabIndex = 4;
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataSource.Location = new System.Drawing.Point(30, 17);
            this.DataSource.MaximumSize = new System.Drawing.Size(390, 0);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(44, 17);
            this.DataSource.TabIndex = 11;
            this.DataSource.Text = "Value";
            // 
            // EnableIncoming
            // 
            this.EnableIncoming.AutoSize = true;
            this.EnableIncoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnableIncoming.Location = new System.Drawing.Point(15, 0);
            this.EnableIncoming.Name = "EnableIncoming";
            this.EnableIncoming.Size = new System.Drawing.Size(126, 17);
            this.EnableIncoming.TabIndex = 1;
            this.EnableIncoming.Text = "Content Database:";
            // 
            // NintexContentDatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParentPanel);
            this.Name = "NintexContentDatabaseControl";
            this.Size = new System.Drawing.Size(421, 66);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.Label EnableIncoming;
    }
}
