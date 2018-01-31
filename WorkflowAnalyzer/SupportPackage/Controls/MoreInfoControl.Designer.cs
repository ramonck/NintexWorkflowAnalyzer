namespace SupportPackage.Controls
{
    partial class MoreInfoControl
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
            this.components = new System.ComponentModel.Container();
            this.MoreInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.MoreInfoTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MoreInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoreInfoPictureBox
            // 
            this.MoreInfoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreInfoPictureBox.Image = global::SupportPackage.Properties.Resources.info;
            this.MoreInfoPictureBox.Location = new System.Drawing.Point(2, 3);
            this.MoreInfoPictureBox.Name = "MoreInfoPictureBox";
            this.MoreInfoPictureBox.Size = new System.Drawing.Size(49, 47);
            this.MoreInfoPictureBox.TabIndex = 13;
            this.MoreInfoPictureBox.TabStop = false;
            this.MoreInfoTooltip.SetToolTip(this.MoreInfoPictureBox, "Click for more information.");
            this.MoreInfoPictureBox.Click += new System.EventHandler(this.Validation_Click);
            // 
            // MoreInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoreInfoPictureBox);
            this.Name = "MoreInfoControl";
            this.Size = new System.Drawing.Size(53, 53);
            ((System.ComponentModel.ISupportInitialize)(this.MoreInfoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoreInfoPictureBox;
        private System.Windows.Forms.ToolTip MoreInfoTooltip;
    }
}
