namespace SupportPackage.Controls
{
    partial class FarmSummaryControl
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
            this.Background = new System.Windows.Forms.Panel();
            this.moreInfoControl1 = new SupportPackage.Controls.MoreInfoControl();
            this.validationControl1 = new SupportPackage.Controls.ValidationControl();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.DBServerName = new System.Windows.Forms.Label();
            this.DatabaseVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.FarmSummaryLabel = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Background.Controls.Add(this.moreInfoControl1);
            this.Background.Controls.Add(this.validationControl1);
            this.Background.Controls.Add(this.DatabaseName);
            this.Background.Controls.Add(this.DBServerName);
            this.Background.Controls.Add(this.DatabaseVersion);
            this.Background.Controls.Add(this.label3);
            this.Background.Controls.Add(this.label2);
            this.Background.Controls.Add(this.Label1);
            this.Background.Controls.Add(this.FarmSummaryLabel);
            this.Background.Location = new System.Drawing.Point(3, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(415, 215);
            this.Background.TabIndex = 1;
            // 
            // moreInfoControl1
            // 
            this.moreInfoControl1.Location = new System.Drawing.Point(357, 159);
            this.moreInfoControl1.Name = "moreInfoControl1";
            this.moreInfoControl1.Size = new System.Drawing.Size(53, 53);
            this.moreInfoControl1.TabIndex = 20;
            // 
            // validationControl1
            // 
            this.validationControl1.Location = new System.Drawing.Point(357, 3);
            this.validationControl1.Name = "validationControl1";
            this.validationControl1.Size = new System.Drawing.Size(55, 53);
            this.validationControl1.TabIndex = 19;
            // 
            // DatabaseName
            // 
            this.DatabaseName.AutoSize = true;
            this.DatabaseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatabaseName.Location = new System.Drawing.Point(135, 67);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(106, 17);
            this.DatabaseName.TabIndex = 18;
            this.DatabaseName.Text = "DatabaseName";
            // 
            // DBServerName
            // 
            this.DBServerName.AutoSize = true;
            this.DBServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DBServerName.Location = new System.Drawing.Point(135, 50);
            this.DBServerName.Name = "DBServerName";
            this.DBServerName.Size = new System.Drawing.Size(87, 17);
            this.DBServerName.TabIndex = 17;
            this.DBServerName.Text = "ServerName";
            // 
            // DatabaseVersion
            // 
            this.DatabaseVersion.AutoSize = true;
            this.DatabaseVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatabaseVersion.Location = new System.Drawing.Point(135, 33);
            this.DatabaseVersion.Name = "DatabaseVersion";
            this.DatabaseVersion.Size = new System.Drawing.Size(108, 17);
            this.DatabaseVersion.TabIndex = 16;
            this.DatabaseVersion.Text = "00.0.0000.0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Database Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Database Server:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 17);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Database Version:";
            // 
            // FarmSummaryLabel
            // 
            this.FarmSummaryLabel.AutoSize = true;
            this.FarmSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmSummaryLabel.Location = new System.Drawing.Point(3, 3);
            this.FarmSummaryLabel.Name = "FarmSummaryLabel";
            this.FarmSummaryLabel.Size = new System.Drawing.Size(139, 24);
            this.FarmSummaryLabel.TabIndex = 12;
            this.FarmSummaryLabel.Text = "Farm Summary";
            // 
            // FarmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Background);
            this.Name = "FarmSummary";
            this.Size = new System.Drawing.Size(421, 221);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Label FarmSummaryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.Label DBServerName;
        private System.Windows.Forms.Label DatabaseVersion;
        private ValidationControl validationControl1;
        private MoreInfoControl moreInfoControl1;

    }
}
