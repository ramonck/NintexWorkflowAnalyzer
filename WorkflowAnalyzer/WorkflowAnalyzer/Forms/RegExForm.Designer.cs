namespace WorkflowAnalyzer.Forms
{
    partial class RegExForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegExForm));
            this.patterntextbox = new System.Windows.Forms.TextBox();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.inputtextbox = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.resultstextbox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.replacetext = new System.Windows.Forms.RadioButton();
            this.checkmatch = new System.Windows.Forms.RadioButton();
            this.split = new System.Windows.Forms.RadioButton();
            this.extract = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ignorecase = new System.Windows.Forms.CheckBox();
            this.replacementlabel = new System.Windows.Forms.Label();
            this.replacementtextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.delimitertextbox = new System.Windows.Forms.TextBox();
            this.delimiterlabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // patterntextbox
            // 
            this.patterntextbox.Location = new System.Drawing.Point(8, 20);
            this.patterntextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patterntextbox.Multiline = true;
            this.patterntextbox.Name = "patterntextbox";
            this.patterntextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patterntextbox.Size = new System.Drawing.Size(564, 94);
            this.patterntextbox.TabIndex = 0;
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(4, 0);
            this.PatternLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(54, 17);
            this.PatternLabel.TabIndex = 1;
            this.PatternLabel.Text = "Pattern";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(4, 0);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(70, 17);
            this.SourceLabel.TabIndex = 3;
            this.SourceLabel.Text = "Input Text";
            // 
            // inputtextbox
            // 
            this.inputtextbox.Location = new System.Drawing.Point(8, 20);
            this.inputtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputtextbox.Multiline = true;
            this.inputtextbox.Name = "inputtextbox";
            this.inputtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputtextbox.Size = new System.Drawing.Size(564, 158);
            this.inputtextbox.TabIndex = 2;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(4, 0);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(55, 17);
            this.ResultsLabel.TabIndex = 5;
            this.ResultsLabel.Text = "Results";
            // 
            // resultstextbox
            // 
            this.resultstextbox.Location = new System.Drawing.Point(8, 20);
            this.resultstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultstextbox.Multiline = true;
            this.resultstextbox.Name = "resultstextbox";
            this.resultstextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultstextbox.Size = new System.Drawing.Size(564, 154);
            this.resultstextbox.TabIndex = 4;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(465, 4);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 28);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // replacetext
            // 
            this.replacetext.AutoSize = true;
            this.replacetext.Checked = true;
            this.replacetext.Location = new System.Drawing.Point(176, 17);
            this.replacetext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replacetext.Name = "replacetext";
            this.replacetext.Size = new System.Drawing.Size(112, 21);
            this.replacetext.TabIndex = 7;
            this.replacetext.TabStop = true;
            this.replacetext.Text = "Replace Text";
            this.replacetext.UseVisualStyleBackColor = true;
            this.replacetext.CheckedChanged += new System.EventHandler(this.replacetext_CheckedChanged);
            // 
            // checkmatch
            // 
            this.checkmatch.AutoSize = true;
            this.checkmatch.Location = new System.Drawing.Point(297, 17);
            this.checkmatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkmatch.Name = "checkmatch";
            this.checkmatch.Size = new System.Drawing.Size(110, 21);
            this.checkmatch.TabIndex = 8;
            this.checkmatch.Text = "Check Match";
            this.checkmatch.UseVisualStyleBackColor = true;
            // 
            // split
            // 
            this.split.AutoSize = true;
            this.split.Location = new System.Drawing.Point(419, 17);
            this.split.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(56, 21);
            this.split.TabIndex = 9;
            this.split.Text = "Split";
            this.split.UseVisualStyleBackColor = true;
            this.split.CheckedChanged += new System.EventHandler(this.split_CheckedChanged);
            // 
            // extract
            // 
            this.extract.AutoSize = true;
            this.extract.Location = new System.Drawing.Point(487, 17);
            this.extract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(71, 21);
            this.extract.TabIndex = 10;
            this.extract.Text = "extract";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.CheckedChanged += new System.EventHandler(this.extract_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extract);
            this.panel1.Controls.Add(this.checkmatch);
            this.panel1.Controls.Add(this.split);
            this.panel1.Controls.Add(this.replacetext);
            this.panel1.Location = new System.Drawing.Point(8, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 60);
            this.panel1.TabIndex = 11;
            // 
            // ignorecase
            // 
            this.ignorecase.AutoSize = true;
            this.ignorecase.Location = new System.Drawing.Point(280, 9);
            this.ignorecase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ignorecase.Name = "ignorecase";
            this.ignorecase.Size = new System.Drawing.Size(173, 21);
            this.ignorecase.TabIndex = 12;
            this.ignorecase.Text = "Ignore Case Sensitivity";
            this.ignorecase.UseVisualStyleBackColor = true;
            // 
            // replacementlabel
            // 
            this.replacementlabel.AutoSize = true;
            this.replacementlabel.Location = new System.Drawing.Point(4, 0);
            this.replacementlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.replacementlabel.Name = "replacementlabel";
            this.replacementlabel.Size = new System.Drawing.Size(122, 17);
            this.replacementlabel.TabIndex = 14;
            this.replacementlabel.Text = "Replacement Text";
            // 
            // replacementtextbox
            // 
            this.replacementtextbox.Location = new System.Drawing.Point(8, 20);
            this.replacementtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replacementtextbox.Multiline = true;
            this.replacementtextbox.Name = "replacementtextbox";
            this.replacementtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replacementtextbox.Size = new System.Drawing.Size(564, 158);
            this.replacementtextbox.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.SourceLabel);
            this.panel2.Controls.Add(this.inputtextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 186);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.replacementlabel);
            this.panel3.Controls.Add(this.replacementtextbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 186);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.ResultsLabel);
            this.panel4.Controls.Add(this.resultstextbox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 372);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 186);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 194);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 608);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.delimitertextbox);
            this.panel6.Controls.Add(this.delimiterlabel);
            this.panel6.Controls.Add(this.ignorecase);
            this.panel6.Controls.Add(this.RunButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 558);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(583, 50);
            this.panel6.TabIndex = 19;
            // 
            // delimitertextbox
            // 
            this.delimitertextbox.Location = new System.Drawing.Point(87, 12);
            this.delimitertextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delimitertextbox.Name = "delimitertextbox";
            this.delimitertextbox.Size = new System.Drawing.Size(132, 22);
            this.delimitertextbox.TabIndex = 22;
            this.delimitertextbox.Text = ";";
            this.delimitertextbox.Visible = false;
            // 
            // delimiterlabel
            // 
            this.delimiterlabel.AutoSize = true;
            this.delimiterlabel.Location = new System.Drawing.Point(16, 16);
            this.delimiterlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delimiterlabel.Name = "delimiterlabel";
            this.delimiterlabel.Size = new System.Drawing.Size(63, 17);
            this.delimiterlabel.TabIndex = 21;
            this.delimiterlabel.Text = "Delimiter";
            this.delimiterlabel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.PatternLabel);
            this.panel8.Controls.Add(this.patterntextbox);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(583, 194);
            this.panel8.TabIndex = 20;
            // 
            // RegExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(583, 804);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(598, 47);
            this.Name = "RegExForm";
            this.Text = "Regular Expression Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegExForm_FormClosed);
            this.Load += new System.EventHandler(this.RegExForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patterntextbox;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.TextBox inputtextbox;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.TextBox resultstextbox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.RadioButton replacetext;
        private System.Windows.Forms.RadioButton checkmatch;
        private System.Windows.Forms.RadioButton split;
        private System.Windows.Forms.RadioButton extract;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ignorecase;
        private System.Windows.Forms.Label replacementlabel;
        private System.Windows.Forms.TextBox replacementtextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox delimitertextbox;
        private System.Windows.Forms.Label delimiterlabel;
    }
}