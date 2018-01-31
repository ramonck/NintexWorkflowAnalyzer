namespace ULSPack.Controls
{
    partial class ULSEntryControl
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
            this.TimeStamp = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.TextBox();
            this.TID = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.EventID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Level = new System.Windows.Forms.TextBox();
            this.CorrelationID = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeStamp
            // 
            this.TimeStamp.Location = new System.Drawing.Point(3, 3);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Size = new System.Drawing.Size(149, 22);
            this.TimeStamp.TabIndex = 0;
            this.TimeStamp.Text = "10/10/2000 10:10:10.10";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(158, 3);
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            this.Process.Size = new System.Drawing.Size(137, 22);
            this.Process.TabIndex = 1;
            this.Process.Text = "OWSTIMER.EXE (sharepointservername:0x3458)";
            // 
            // TID
            // 
            this.TID.Location = new System.Drawing.Point(301, 3);
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Size = new System.Drawing.Size(54, 22);
            this.TID.TabIndex = 2;
            this.TID.Text = "0x851C";
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(361, 3);
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Size = new System.Drawing.Size(150, 22);
            this.Area.TabIndex = 3;
            this.Area.Text = "SharePoint Foundation ";
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(517, 3);
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Size = new System.Drawing.Size(76, 22);
            this.Category.TabIndex = 4;
            this.Category.Text = "Monitoring";
            // 
            // EventID
            // 
            this.EventID.Location = new System.Drawing.Point(599, 3);
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            this.EventID.Size = new System.Drawing.Size(55, 22);
            this.EventID.TabIndex = 5;
            this.EventID.Text = "aeh57";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.TimeStamp);
            this.flowLayoutPanel1.Controls.Add(this.Process);
            this.flowLayoutPanel1.Controls.Add(this.TID);
            this.flowLayoutPanel1.Controls.Add(this.Area);
            this.flowLayoutPanel1.Controls.Add(this.Category);
            this.flowLayoutPanel1.Controls.Add(this.EventID);
            this.flowLayoutPanel1.Controls.Add(this.Level);
            this.flowLayoutPanel1.Controls.Add(this.CorrelationID);
            this.flowLayoutPanel1.Controls.Add(this.Message);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1400, 28);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(660, 3);
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Size = new System.Drawing.Size(62, 22);
            this.Level.TabIndex = 7;
            this.Level.Text = "Medium";
            // 
            // CorrelationID
            // 
            this.CorrelationID.Location = new System.Drawing.Point(728, 3);
            this.CorrelationID.Name = "CorrelationID";
            this.CorrelationID.ReadOnly = true;
            this.CorrelationID.Size = new System.Drawing.Size(247, 22);
            this.CorrelationID.TabIndex = 8;
            this.CorrelationID.Text = "00000000-0000-0000-0000-000000000000";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(981, 3);
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(416, 22);
            this.Message.TabIndex = 9;
            this.Message.Text = "Message";
            // 
            // ULSEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ULSEntryControl";
            this.Size = new System.Drawing.Size(1406, 34);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeStamp;
        private System.Windows.Forms.TextBox Process;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox EventID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.TextBox CorrelationID;
        private System.Windows.Forms.TextBox Message;
    }
}
