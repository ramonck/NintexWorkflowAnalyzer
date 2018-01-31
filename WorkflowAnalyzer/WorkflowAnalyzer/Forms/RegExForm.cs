using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WorkflowAnalyzer.Forms
{
    public partial class RegExForm : Form
    {

        private BackgroundWorker _worker = null;
        private int xpos = Properties.Settings.Default.RegexLocationX;
        private int ypos = Properties.Settings.Default.RegexLocationY;

        public RegExForm()
        {
            InitializeComponent();
        }

        private void RegExForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            if (Properties.Settings.Default.RememberWindowLocations & xpos != 0 & ypos != 0)
            {
                    this.Location = new Point(xpos, ypos);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (_worker == null)
            {
                _worker = new BackgroundWorker();
                _worker.DoWork += _worker_DoWork;
                _worker.RunWorkerAsync();
            }
            else
            {
                _worker.RunWorkerAsync();
            }
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            resultstextbox.Invoke((MethodInvoker)delegate()
            {
                resultstextbox.Text = "";
            });
            
            Regex _regex;

            if (ignorecase.Checked)
            {
                _regex = new Regex(patterntextbox.Text, RegexOptions.IgnoreCase);
            }
            else
            {
                _regex = new Regex(patterntextbox.Text, RegexOptions.IgnoreCase);
            }

            if (replacetext.Checked)
            {
                resultstextbox.Invoke((MethodInvoker)delegate()
                {
                    resultstextbox.Text = _regex.Replace(inputtextbox.Text, replacementtextbox.Text);
                });
            }
            if (checkmatch.Checked)
            {
                resultstextbox.Invoke((MethodInvoker)delegate()
                {
                    resultstextbox.Text = _regex.IsMatch(inputtextbox.Text).ToString();
                });  
            }
            if (split.Checked)
            {
                string[] stage = _regex.Split(inputtextbox.Text);
                foreach (String match in stage)
                {
                    resultstextbox.Invoke((MethodInvoker)delegate()
                    {
                        resultstextbox.AppendText(match + delimitertextbox.Text);
                    });   
                }
            }
            if (extract.Checked)
            {

                MatchCollection stage = _regex.Matches(inputtextbox.Text); ;
                foreach (Match match in stage)
                {
                    resultstextbox.Invoke((MethodInvoker)delegate()
                    {
                        resultstextbox.AppendText(match.Value + delimitertextbox.Text);
                    });   
                }
            }
        }

        private void replacetext_CheckedChanged(object sender, EventArgs e)
        {
            if (replacetext.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void split_CheckedChanged(object sender, EventArgs e)
        {
            if (split.Checked)
            {
                showdelimiter(true);
            }
            else
            {
                showdelimiter(false);
            }
        }

        private void extract_CheckedChanged(object sender, EventArgs e)
        {
            if (extract.Checked)
            {
                showdelimiter(true);
            }
            else
            {
                showdelimiter(false);
            }
        }

        private void showdelimiter(Boolean show)
        {
            delimitertextbox.Visible = show;
            delimiterlabel.Visible = show;
        }

        private void RegExForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.RegexLocationX = this.Location.X;
            Properties.Settings.Default.RegexLocationY = this.Location.Y;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }
    }
}
