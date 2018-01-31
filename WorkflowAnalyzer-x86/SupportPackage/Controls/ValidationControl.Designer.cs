namespace SupportPackage.Controls
{
    partial class ValidationControl
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
            this.Validation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Validation)).BeginInit();
            this.SuspendLayout();
            // 
            // Validation
            // 
            this.Validation.Image = global::SupportPackage.Properties.Resources.Success;
            this.Validation.Location = new System.Drawing.Point(3, 3);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(49, 47);
            this.Validation.TabIndex = 12;
            this.Validation.TabStop = false;
            // 
            // ValidationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Validation);
            this.Name = "ValidationControl";
            this.Size = new System.Drawing.Size(55, 53);
            ((System.ComponentModel.ISupportInitialize)(this.Validation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Validation;
    }
}
