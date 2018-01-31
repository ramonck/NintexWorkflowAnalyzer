namespace SupportPackage.Controls
{
    partial class FarmSolutionControl
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
            this.SolutionName = new System.Windows.Forms.Label();
            this.SolutionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SolutionName
            // 
            this.SolutionName.AutoSize = true;
            this.SolutionName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SolutionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SolutionName.Location = new System.Drawing.Point(3, 0);
            this.SolutionName.Name = "SolutionName";
            this.SolutionName.Size = new System.Drawing.Size(124, 17);
            this.SolutionName.TabIndex = 13;
            this.SolutionName.Text = "SolutionName.wsp";
            this.SolutionToolTip.SetToolTip(this.SolutionName, "Click for more information.");
            this.SolutionName.Click += new System.EventHandler(this.SolutionName_Click);
            // 
            // FarmSolutionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SolutionName);
            this.Name = "FarmSolutionControl";
            this.Size = new System.Drawing.Size(421, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SolutionName;
        private System.Windows.Forms.ToolTip SolutionToolTip;
    }
}
