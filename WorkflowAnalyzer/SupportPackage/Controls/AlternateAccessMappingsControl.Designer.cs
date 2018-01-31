namespace SupportPackage.Controls
{
    partial class AlternateAccessMappingsControl
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
            this.Title = new System.Windows.Forms.Label();
            this.AAMFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.AAMFlowPanel);
            this.ParentPanel.Controls.Add(this.Title);
            this.ParentPanel.Location = new System.Drawing.Point(3, 3);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(415, 274);
            this.ParentPanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Location = new System.Drawing.Point(4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(204, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Alternate Access Mappings";
            // 
            // AAMFlowPanel
            // 
            this.AAMFlowPanel.AutoScroll = true;
            this.AAMFlowPanel.Location = new System.Drawing.Point(3, 20);
            this.AAMFlowPanel.Name = "AAMFlowPanel";
            this.AAMFlowPanel.Size = new System.Drawing.Size(409, 251);
            this.AAMFlowPanel.TabIndex = 1;
            // 
            // AlternateAccessMappingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParentPanel);
            this.Name = "AlternateAccessMappingsControl";
            this.Size = new System.Drawing.Size(421, 280);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.FlowLayoutPanel AAMFlowPanel;
        private System.Windows.Forms.Label Title;
    }
}
