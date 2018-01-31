namespace WorkflowAnalyzer.Controls
{
    partial class ActionIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionIcon));
            this.ActionIconPictureBox = new System.Windows.Forms.PictureBox();
            this.TLabelTextbox = new System.Windows.Forms.TextBox();
            this.RLabelTextbox = new System.Windows.Forms.TextBox();
            this.LLabelTextbox = new System.Windows.Forms.TextBox();
            this.BLabelTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActionIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionIconPictureBox
            // 
            this.ActionIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActionIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ActionIconPictureBox.Image")));
            this.ActionIconPictureBox.Location = new System.Drawing.Point(57, 26);
            this.ActionIconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActionIconPictureBox.Name = "ActionIconPictureBox";
            this.ActionIconPictureBox.Size = new System.Drawing.Size(48, 48);
            this.ActionIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ActionIconPictureBox.TabIndex = 0;
            this.ActionIconPictureBox.TabStop = false;
            this.ActionIconPictureBox.DoubleClick += new System.EventHandler(this.ActionIconPictureBox_DoubleClick);
            // 
            // TLabelTextbox
            // 
            this.TLabelTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TLabelTextbox.Location = new System.Drawing.Point(5, 2);
            this.TLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.TLabelTextbox.Name = "TLabelTextbox";
            this.TLabelTextbox.Size = new System.Drawing.Size(156, 20);
            this.TLabelTextbox.TabIndex = 1;
            // 
            // RLabelTextbox
            // 
            this.RLabelTextbox.Location = new System.Drawing.Point(111, 26);
            this.RLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.RLabelTextbox.Name = "RLabelTextbox";
            this.RLabelTextbox.Size = new System.Drawing.Size(48, 20);
            this.RLabelTextbox.TabIndex = 2;
            // 
            // LLabelTextbox
            // 
            this.LLabelTextbox.Location = new System.Drawing.Point(4, 26);
            this.LLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LLabelTextbox.Name = "LLabelTextbox";
            this.LLabelTextbox.Size = new System.Drawing.Size(48, 20);
            this.LLabelTextbox.TabIndex = 3;
            // 
            // BLabelTextbox
            // 
            this.BLabelTextbox.Location = new System.Drawing.Point(56, 78);
            this.BLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.BLabelTextbox.Name = "BLabelTextbox";
            this.BLabelTextbox.Size = new System.Drawing.Size(48, 20);
            this.BLabelTextbox.TabIndex = 4;
            // 
            // ActionIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BLabelTextbox);
            this.Controls.Add(this.LLabelTextbox);
            this.Controls.Add(this.RLabelTextbox);
            this.Controls.Add(this.TLabelTextbox);
            this.Controls.Add(this.ActionIconPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(166, 105);
            this.MinimumSize = new System.Drawing.Size(166, 105);
            this.Name = "ActionIcon";
            this.Size = new System.Drawing.Size(164, 103);
            ((System.ComponentModel.ISupportInitialize)(this.ActionIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ActionIconPictureBox;
        private System.Windows.Forms.TextBox TLabelTextbox;
        private System.Windows.Forms.TextBox RLabelTextbox;
        private System.Windows.Forms.TextBox LLabelTextbox;
        private System.Windows.Forms.TextBox BLabelTextbox;
    }
}
