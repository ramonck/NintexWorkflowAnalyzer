namespace SupportPackage.Controls
{
    partial class NintexDatabaseMappingControl
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
            this.SiteIdValue = new System.Windows.Forms.Label();
            this.SiteId = new System.Windows.Forms.Label();
            this.SiteUrl = new System.Windows.Forms.Label();
            this.SiteUrlValue = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.DatabaseNameValue = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.DatabaseNameValue);
            this.ParentPanel.Controls.Add(this.DatabaseName);
            this.ParentPanel.Controls.Add(this.SiteUrlValue);
            this.ParentPanel.Controls.Add(this.SiteUrl);
            this.ParentPanel.Controls.Add(this.SiteIdValue);
            this.ParentPanel.Controls.Add(this.SiteId);
            this.ParentPanel.Location = new System.Drawing.Point(3, 3);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(415, 56);
            this.ParentPanel.TabIndex = 5;
            // 
            // SiteIdValue
            // 
            this.SiteIdValue.AutoSize = true;
            this.SiteIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SiteIdValue.Location = new System.Drawing.Point(140, 0);
            this.SiteIdValue.MaximumSize = new System.Drawing.Size(390, 0);
            this.SiteIdValue.Name = "SiteIdValue";
            this.SiteIdValue.Size = new System.Drawing.Size(44, 17);
            this.SiteIdValue.TabIndex = 11;
            this.SiteIdValue.Text = "Value";
            // 
            // SiteId
            // 
            this.SiteId.AutoSize = true;
            this.SiteId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SiteId.Location = new System.Drawing.Point(15, 0);
            this.SiteId.Name = "SiteId";
            this.SiteId.Size = new System.Drawing.Size(51, 17);
            this.SiteId.TabIndex = 1;
            this.SiteId.Text = "Site Id:";
            // 
            // SiteUrl
            // 
            this.SiteUrl.AutoSize = true;
            this.SiteUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SiteUrl.Location = new System.Drawing.Point(15, 17);
            this.SiteUrl.Name = "SiteUrl";
            this.SiteUrl.Size = new System.Drawing.Size(58, 17);
            this.SiteUrl.TabIndex = 12;
            this.SiteUrl.Text = "Site Url:";
            // 
            // SiteUrlValue
            // 
            this.SiteUrlValue.AutoSize = true;
            this.SiteUrlValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SiteUrlValue.Location = new System.Drawing.Point(140, 17);
            this.SiteUrlValue.MaximumSize = new System.Drawing.Size(390, 0);
            this.SiteUrlValue.Name = "SiteUrlValue";
            this.SiteUrlValue.Size = new System.Drawing.Size(44, 17);
            this.SiteUrlValue.TabIndex = 13;
            this.SiteUrlValue.Text = "Value";
            // 
            // DatabaseName
            // 
            this.DatabaseName.AutoSize = true;
            this.DatabaseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatabaseName.Location = new System.Drawing.Point(15, 34);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(114, 17);
            this.DatabaseName.TabIndex = 14;
            this.DatabaseName.Text = "Database Name:";
            // 
            // DatabaseNameValue
            // 
            this.DatabaseNameValue.AutoSize = true;
            this.DatabaseNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatabaseNameValue.Location = new System.Drawing.Point(140, 34);
            this.DatabaseNameValue.MaximumSize = new System.Drawing.Size(390, 0);
            this.DatabaseNameValue.Name = "DatabaseNameValue";
            this.DatabaseNameValue.Size = new System.Drawing.Size(44, 17);
            this.DatabaseNameValue.TabIndex = 15;
            this.DatabaseNameValue.Text = "Value";
            // 
            // NintexDatabaseMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParentPanel);
            this.Name = "NintexDatabaseMapping";
            this.Size = new System.Drawing.Size(421, 62);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Label SiteIdValue;
        private System.Windows.Forms.Label SiteId;
        private System.Windows.Forms.Label DatabaseNameValue;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.Label SiteUrlValue;
        private System.Windows.Forms.Label SiteUrl;
    }
}
