namespace SupportPackage.Controls
{
    partial class AlternateAccessMappingControl
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
            this.InternalUrl = new System.Windows.Forms.Label();
            this.Zone = new System.Windows.Forms.Label();
            this.PublicUrl = new System.Windows.Forms.Label();
            this.InternalUrlValue = new System.Windows.Forms.Label();
            this.ZoneValue = new System.Windows.Forms.Label();
            this.PublicUrlValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InternalUrl
            // 
            this.InternalUrl.AutoSize = true;
            this.InternalUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InternalUrl.Location = new System.Drawing.Point(3, 0);
            this.InternalUrl.Name = "InternalUrl";
            this.InternalUrl.Size = new System.Drawing.Size(81, 17);
            this.InternalUrl.TabIndex = 1;
            this.InternalUrl.Text = "Internal Url:";
            // 
            // Zone
            // 
            this.Zone.AutoSize = true;
            this.Zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Zone.Location = new System.Drawing.Point(3, 17);
            this.Zone.Name = "Zone";
            this.Zone.Size = new System.Drawing.Size(45, 17);
            this.Zone.TabIndex = 2;
            this.Zone.Text = "Zone:";
            // 
            // PublicUrl
            // 
            this.PublicUrl.AutoSize = true;
            this.PublicUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PublicUrl.Location = new System.Drawing.Point(3, 34);
            this.PublicUrl.Name = "PublicUrl";
            this.PublicUrl.Size = new System.Drawing.Size(72, 17);
            this.PublicUrl.TabIndex = 3;
            this.PublicUrl.Text = "Public Url:";
            // 
            // InternalUrlValue
            // 
            this.InternalUrlValue.AutoSize = true;
            this.InternalUrlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalUrlValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InternalUrlValue.Location = new System.Drawing.Point(90, 0);
            this.InternalUrlValue.Name = "InternalUrlValue";
            this.InternalUrlValue.Size = new System.Drawing.Size(42, 17);
            this.InternalUrlValue.TabIndex = 4;
            this.InternalUrlValue.Text = "value";
            // 
            // ZoneValue
            // 
            this.ZoneValue.AutoSize = true;
            this.ZoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZoneValue.Location = new System.Drawing.Point(90, 17);
            this.ZoneValue.Name = "ZoneValue";
            this.ZoneValue.Size = new System.Drawing.Size(42, 17);
            this.ZoneValue.TabIndex = 5;
            this.ZoneValue.Text = "value";
            // 
            // PublicUrlValue
            // 
            this.PublicUrlValue.AutoSize = true;
            this.PublicUrlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicUrlValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PublicUrlValue.Location = new System.Drawing.Point(90, 34);
            this.PublicUrlValue.Name = "PublicUrlValue";
            this.PublicUrlValue.Size = new System.Drawing.Size(42, 17);
            this.PublicUrlValue.TabIndex = 6;
            this.PublicUrlValue.Text = "value";
            // 
            // AlternateAccessMappingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PublicUrlValue);
            this.Controls.Add(this.ZoneValue);
            this.Controls.Add(this.InternalUrlValue);
            this.Controls.Add(this.PublicUrl);
            this.Controls.Add(this.Zone);
            this.Controls.Add(this.InternalUrl);
            this.Name = "AlternateAccessMappingControl";
            this.Size = new System.Drawing.Size(400, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InternalUrl;
        private System.Windows.Forms.Label Zone;
        private System.Windows.Forms.Label PublicUrl;
        private System.Windows.Forms.Label InternalUrlValue;
        private System.Windows.Forms.Label ZoneValue;
        private System.Windows.Forms.Label PublicUrlValue;
    }
}
