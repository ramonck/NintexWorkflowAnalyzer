namespace SupportPackage.Controls
{
    partial class NintexLazyApprovalControl
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
            this.EmailAliasValue = new System.Windows.Forms.Label();
            this.EnabledValue = new System.Windows.Forms.Label();
            this.EmailAlias = new System.Windows.Forms.Label();
            this.Enabled = new System.Windows.Forms.Label();
            this.LazyApprovalTitle = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.EmailAliasValue);
            this.ParentPanel.Controls.Add(this.EnabledValue);
            this.ParentPanel.Controls.Add(this.EmailAlias);
            this.ParentPanel.Controls.Add(this.Enabled);
            this.ParentPanel.Controls.Add(this.LazyApprovalTitle);
            this.ParentPanel.Location = new System.Drawing.Point(3, 3);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(415, 86);
            this.ParentPanel.TabIndex = 3;
            // 
            // EmailAliasValue
            // 
            this.EmailAliasValue.AutoSize = true;
            this.EmailAliasValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailAliasValue.Location = new System.Drawing.Point(120, 50);
            this.EmailAliasValue.Name = "EmailAliasValue";
            this.EmailAliasValue.Size = new System.Drawing.Size(42, 17);
            this.EmailAliasValue.TabIndex = 12;
            this.EmailAliasValue.Text = "value";
            // 
            // EnabledValue
            // 
            this.EnabledValue.AutoSize = true;
            this.EnabledValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnabledValue.Location = new System.Drawing.Point(120, 33);
            this.EnabledValue.Name = "EnabledValue";
            this.EnabledValue.Size = new System.Drawing.Size(42, 17);
            this.EnabledValue.TabIndex = 11;
            this.EnabledValue.Text = "value";
            // 
            // EmailAlias
            // 
            this.EmailAlias.AutoSize = true;
            this.EmailAlias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailAlias.Location = new System.Drawing.Point(15, 50);
            this.EmailAlias.Name = "EmailAlias";
            this.EmailAlias.Size = new System.Drawing.Size(80, 17);
            this.EmailAlias.TabIndex = 2;
            this.EmailAlias.Text = "Email Alias:";
            // 
            // Enabled
            // 
            this.Enabled.AutoSize = true;
            this.Enabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Enabled.Location = new System.Drawing.Point(15, 33);
            this.Enabled.Name = "Enabled";
            this.Enabled.Size = new System.Drawing.Size(64, 17);
            this.Enabled.TabIndex = 1;
            this.Enabled.Text = "Enabled:";
            // 
            // LazyApprovalTitle
            // 
            this.LazyApprovalTitle.AutoSize = true;
            this.LazyApprovalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LazyApprovalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LazyApprovalTitle.Location = new System.Drawing.Point(3, 16);
            this.LazyApprovalTitle.Name = "LazyApprovalTitle";
            this.LazyApprovalTitle.Size = new System.Drawing.Size(111, 17);
            this.LazyApprovalTitle.TabIndex = 0;
            this.LazyApprovalTitle.Text = "Lazy Approval";
            // 
            // NintexLazyApprovalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParentPanel);
            this.Name = "NintexLazyApprovalControl";
            this.Size = new System.Drawing.Size(421, 92);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Label EmailAliasValue;
        private System.Windows.Forms.Label EnabledValue;
        private System.Windows.Forms.Label EmailAlias;
        private System.Windows.Forms.Label Enabled;
        private System.Windows.Forms.Label LazyApprovalTitle;
    }
}
