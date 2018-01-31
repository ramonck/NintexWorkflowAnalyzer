namespace SupportPackage.Controls
{
    partial class SharePointServer
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
            this.validationControl1 = new SupportPackage.Controls.ValidationControl();
            this.ServerName = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.Label();
            this.WebApplication = new System.Windows.Forms.Label();
            this.WorkflowInfrastructure = new System.Windows.Forms.Label();
            this.IncomingEmail = new System.Windows.Forms.Label();
            this.ProjectServer = new System.Windows.Forms.Label();
            this.moreInfoControl1 = new SupportPackage.Controls.MoreInfoControl();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Background.Controls.Add(this.moreInfoControl1);
            this.Background.Controls.Add(this.ProjectServer);
            this.Background.Controls.Add(this.IncomingEmail);
            this.Background.Controls.Add(this.WorkflowInfrastructure);
            this.Background.Controls.Add(this.WebApplication);
            this.Background.Controls.Add(this.validationControl1);
            this.Background.Controls.Add(this.ServerName);
            this.Background.Controls.Add(this.Services);
            this.Background.Location = new System.Drawing.Point(3, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(415, 215);
            this.Background.TabIndex = 0;
            // 
            // validationControl1
            // 
            this.validationControl1.Location = new System.Drawing.Point(357, 3);
            this.validationControl1.Name = "validationControl1";
            this.validationControl1.Size = new System.Drawing.Size(55, 53);
            this.validationControl1.TabIndex = 11;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerName.Location = new System.Drawing.Point(3, 3);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(65, 24);
            this.ServerName.TabIndex = 4;
            this.ServerName.Text = "Server";
            // 
            // Services
            // 
            this.Services.AutoSize = true;
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(4, 108);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(65, 18);
            this.Services.TabIndex = 3;
            this.Services.Text = "Services";
            // 
            // WebApplication
            // 
            this.WebApplication.AutoSize = true;
            this.WebApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WebApplication.Location = new System.Drawing.Point(13, 135);
            this.WebApplication.Name = "WebApplication";
            this.WebApplication.Size = new System.Drawing.Size(110, 17);
            this.WebApplication.TabIndex = 12;
            this.WebApplication.Text = "Web Application";
            // 
            // WorkflowInfrastructure
            // 
            this.WorkflowInfrastructure.AutoSize = true;
            this.WorkflowInfrastructure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WorkflowInfrastructure.Location = new System.Drawing.Point(13, 152);
            this.WorkflowInfrastructure.Name = "WorkflowInfrastructure";
            this.WorkflowInfrastructure.Size = new System.Drawing.Size(153, 17);
            this.WorkflowInfrastructure.TabIndex = 13;
            this.WorkflowInfrastructure.Text = "Workflow Infrastructure";
            // 
            // IncomingEmail
            // 
            this.IncomingEmail.AutoSize = true;
            this.IncomingEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IncomingEmail.Location = new System.Drawing.Point(13, 169);
            this.IncomingEmail.Name = "IncomingEmail";
            this.IncomingEmail.Size = new System.Drawing.Size(107, 17);
            this.IncomingEmail.TabIndex = 14;
            this.IncomingEmail.Text = "Incoming E-Mail";
            // 
            // ProjectServer
            // 
            this.ProjectServer.AutoSize = true;
            this.ProjectServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectServer.Location = new System.Drawing.Point(13, 186);
            this.ProjectServer.Name = "ProjectServer";
            this.ProjectServer.Size = new System.Drawing.Size(98, 17);
            this.ProjectServer.TabIndex = 15;
            this.ProjectServer.Text = "Project Server";
            // 
            // moreInfoControl1
            // 
            this.moreInfoControl1.Location = new System.Drawing.Point(357, 154);
            this.moreInfoControl1.Name = "moreInfoControl1";
            this.moreInfoControl1.Size = new System.Drawing.Size(53, 53);
            this.moreInfoControl1.TabIndex = 16;
            // 
            // SharePointServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Background);
            this.Name = "SharePointServer";
            this.Size = new System.Drawing.Size(421, 221);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label Services;
        private ValidationControl validationControl1;
        private MoreInfoControl moreInfoControl1;
        private System.Windows.Forms.Label ProjectServer;
        private System.Windows.Forms.Label IncomingEmail;
        private System.Windows.Forms.Label WorkflowInfrastructure;
        private System.Windows.Forms.Label WebApplication;
    }
}
