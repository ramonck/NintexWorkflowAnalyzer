

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ScintillaNET;
using WorkflowAnalyzer.Properties;

namespace WorkflowAnalyzer.Tabs
{
    internal class EditorTab : ITabContext
    {
        public TabPage Tab { get; set; }

        public string TabTitle { get; set; }

        public Control ChildControl { get; set; }

        private SplitContainer splitContainer;

        public EditorTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            LoadControls(nwfContext);

            InitializeChildControl();
        }

        public void InitializeTab()
        {
            Tab = new TabPage();
            Tab.Text = TabTitle;
        }

        public void InitializeChildControl()
        {
            ChildControl = splitContainer;
            Tab.Controls.Add(ChildControl);
        }

        private void LoadControls(NWFContext nwfContext)
        {
            splitContainer = new SplitContainer();
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Orientation = Orientation.Horizontal;

            WebBrowser previewBrowser = new WebBrowser();
            previewBrowser.Dock = DockStyle.Fill;

            #region ExternalXml
            ScintillaNET.Scintilla exEditor = new ScintillaNET.Scintilla();

            exEditor.Dock = DockStyle.Fill;

            splitContainer.Panel1.Controls.Add(exEditor);

            exEditor.Margins.Left = 10;
            exEditor.Margins.Right = 20;
            exEditor.Lexer = Lexer.Xml;
            exEditor.LexerLanguage = "xml";
            exEditor.SetProperty("fold", "1");
            exEditor.SetProperty("fold.compact", "1");
            exEditor.Text = (nwfContext.NWFXmlDocument.InnerXml).Replace("><", ">" + Environment.NewLine + "<");
            #endregion

            #region InternalXml
            Scintilla inEditor = new Scintilla();

            inEditor.Dock = DockStyle.Fill;

            splitContainer.Panel1.Controls.Add(inEditor);
            inEditor.Visible = false;

            inEditor.Margins.Left = 10;
            inEditor.Margins.Right = 20;
            inEditor.Lexer = Lexer.Xml;
            inEditor.LexerLanguage = "xml";
            inEditor.SetProperty("fold", "1");
            inEditor.SetProperty("fold.compact", "1");
            var xmlNode = nwfContext.NWFXmlDocument.ChildNodes.Item(1);
            if (xmlNode != null)
                inEditor.Text = (xmlNode.FirstChild.InnerText).Replace("><", ">" + Environment.NewLine + "<");
            #endregion

            #region Toolbar
            ToolStrip strip = new ToolStrip();
            strip.Dock = DockStyle.Top;

            ToolStripButton savebutton = new ToolStripButton();
            savebutton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Save;
            savebutton.ToolTipText = Resources.WfaMain_LoadXmlEditorWithContent_Save_changes_to_new_NWF_file_;
            strip.Items.Add(savebutton);
            savebutton.Click += (delegate
            {
                nwfContext.SetStagedWorkflowConfiguration(exEditor.Text);
                nwfContext.SetStagedWorkflowConfiguration(inEditor.Text.Replace(Environment.NewLine, ""));
                //nwfContext.SaveStringToFile(nwfContext.NwfXmlModifiedByEditor.InnerXml, "nwf"); NEEDS TO BE REFACTORED
            });

            ToolStripButton resetbutton = new ToolStripButton();
            resetbutton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Reset;
            resetbutton.ToolTipText = Resources.WfaMain_LoadXmlEditorWithContent_Reset_XML_to_default;
            strip.Items.Add(resetbutton);
            resetbutton.Click += (delegate
            {
                //saveWorkflowPreviewToolStripMenuItem.Enabled = false; NEEDS TO BE REFACTORED
                nwfContext.NWFXmlModified = null;
                exEditor.Text = (nwfContext.NWFXmlDocument.InnerXml).Replace("><", ">" + Environment.NewLine + "<");
                var item = nwfContext.NWFXmlDocument.ChildNodes.Item(1);
                if (item != null)
                    inEditor.Text = (item.FirstChild.InnerText).Replace("><", ">" + Environment.NewLine + "<");
            });

            ToolStripButton previewbutton = new ToolStripButton();
            previewbutton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Preview_Changes;
            previewbutton.ToolTipText = Resources.WfaMain_LoadXmlEditorWithContent_Preview_Changes_made_to_XML;
            strip.Items.Add(previewbutton);
            previewbutton.Click += (delegate
            {
                try
                {
                    nwfContext.SetStagedWorkflowConfiguration(exEditor.Text);
                    nwfContext.SetStagedWorkflowConfiguration(inEditor.Text);

                    XmlDocument previewdoc = new XmlDocument();
                    var item = nwfContext.NWFXmlModified.ChildNodes.Item(1);
                    if (item != null)
                        previewdoc.LoadXml(item.FirstChild.InnerText);
                    var xmlNodeList = previewdoc.SelectNodes("//ExportedWorkflow");
                    if (xmlNodeList != null)
                    {
                        XmlNode wfGraphical = xmlNodeList[0];

                        //previewTab.Text = Resources.WfaMain_LoadXmlEditorWithContent_Preview;
                        previewBrowser.Dock = DockStyle.Fill;
                        //previewTab.Controls.Add(_previewBrowser);

                        String staging;
                        staging = Common.ConvertXmlToHtml(wfGraphical.OuterXml, "graphical.xsl");
                        staging = staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\"));

                        #region Populate Browser
                        previewBrowser.DocumentText = staging;
                    }

                        #endregion

                    //saveWorkflowPreviewToolStripMenuItem.Enabled = true; NEEDS TO BE REFACTORED
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.WfaMain_LoadXmlEditorWithContent_Failed_to_render_preview__ + ex);
                }
            });

            #endregion

            #region ToolbarV2

            Panel toolbarPanel = new Panel();

            toolbarPanel.Dock = DockStyle.Top;

            splitContainer.Panel1.Controls.Add(toolbarPanel);
            splitContainer.Panel2.Controls.Add(previewBrowser);

            #region Populate Preview Browser with Temp Text

            StringBuilder sb = new StringBuilder();

            sb.Append("<html>");
            sb.Append("<body>");
            sb.Append("<br>");
            sb.Append("<center><h2><font color=\"grey\" face=\"serif\">Click Preview to display a graphical view of the edited XML</font></h2></center>");
            sb.Append("</body>");
            sb.Append("</html>");

            previewBrowser.DocumentText = sb.ToString();

            #endregion

            Label editorDescriptionLabel = new Label();

            Button saveButton = new Button();

            #region SaveButton
            saveButton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Save;
            saveButton.AutoSize = true;
            saveButton.Click += (delegate
            {
                nwfContext.SetStagedWorkflowConfiguration(exEditor.Text);
                nwfContext.SetStagedWorkflowConfiguration(inEditor.Text.Replace(Environment.NewLine, ""));
                //nwfContext.SaveStringToFile(nwfContext.NwfXmlModifiedByEditor.InnerXml, "nwf"); NEEDS TO BE REFACTORED
                nwfContext.SaveStringToFile(nwfContext.NWFXmlModified.InnerXml, "nwf");
            });
            #endregion

            Button resetButton = new Button();

            #region ResetButton
            resetButton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Reset;
            resetButton.AutoSize = true;
            resetButton.Click += (delegate
            {
                //saveWorkflowPreviewToolStripMenuItem.Enabled = false; NEEDS TO BE REFACTORED
                nwfContext.NWFXmlModified = null;
                exEditor.Text = (nwfContext.NWFXmlDocument.InnerXml).Replace("><", ">" + Environment.NewLine + "<");
                var item = nwfContext.NWFXmlDocument.ChildNodes.Item(1);
                if (item != null)
                    inEditor.Text = (item.FirstChild.InnerText).Replace("><", ">" + Environment.NewLine + "<");
            });
            #endregion

            Button previewButton = new Button();

            #region PreviewButton

            previewButton.Text = Resources.WfaMain_LoadXmlEditorWithContent_Preview_Changes;
            previewButton.Click += (delegate
            {
                try
                {
                    nwfContext.SetStagedWorkflowConfiguration(exEditor.Text);
                    nwfContext.SetStagedWorkflowConfiguration(inEditor.Text);

                    XmlDocument previewdoc = new XmlDocument();
                    var item = nwfContext.NWFXmlModified.ChildNodes.Item(1);
                    if (item != null)
                        previewdoc.LoadXml(item.FirstChild.InnerText);
                    var xmlNodeList = previewdoc.SelectNodes("//ExportedWorkflow");
                    if (xmlNodeList != null)
                    {
                        XmlNode wfGraphical = xmlNodeList[0];

                        String staging;
                        staging = Common.ConvertXmlToHtml(wfGraphical.OuterXml, "graphical.xsl");
                        staging = staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\"));

                        #region Populate Browser
                        previewBrowser.DocumentText = staging;
                    }

                        #endregion

                    //saveWorkflowPreviewToolStripMenuItem.Enabled = true; NEEDS TO BE REFACTORED
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.WfaMain_LoadXmlEditorWithContent_Failed_to_render_preview__ + ex);
                }
            });
            #endregion

            ComboBox editorComboBox = new ComboBox();

            #region EditorComboBox

            editorComboBox.Width = 150;

            editorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editorComboBox.Items.Add("View: External XML");
            editorComboBox.Items.Add("View: Internal XML");
            editorComboBox.SelectedIndex = 0;

            editorComboBox.SelectedIndexChanged += delegate
            {
                switch (editorComboBox.SelectedIndex)
                {
                    case 0:
                        exEditor.Visible = true;
                        inEditor.Visible = false;
                        editorDescriptionLabel.Text =
                "The external XML view highlights SharePoint context, including list references.";
                        break;
                    case 1:
                        exEditor.Visible = false;
                        inEditor.Visible = true;
                        editorDescriptionLabel.Text =
                "The internal XML view highlights workflow configuration, including actions.";
                        break;
                }
            };

            #endregion




            toolbarPanel.Controls.Add(editorComboBox);
            toolbarPanel.Controls.Add(previewButton);
            toolbarPanel.Controls.Add(saveButton);
            toolbarPanel.Controls.Add(resetButton);
            toolbarPanel.Controls.Add(editorDescriptionLabel);
            toolbarPanel.Height = previewButton.Height + editorDescriptionLabel.Height + 20;


            editorComboBox.Location = new Point(editorComboBox.Location.X + 10, editorComboBox.Location.Y + 10);
            previewButton.Location = new Point(editorComboBox.Location.X + editorComboBox.Width + 10, editorComboBox.Location.Y);
            saveButton.Location = new Point(previewButton.Location.X + previewButton.Width + 10, editorComboBox.Location.Y);
            resetButton.Location = new Point(saveButton.Location.X + saveButton.Width + 10, editorComboBox.Location.Y);

            editorDescriptionLabel.Location = new Point(editorComboBox.Location.X, editorComboBox.Location.Y + editorComboBox.Height + 10);
            editorDescriptionLabel.AutoSize = true;

            editorDescriptionLabel.Text =
                "The external XML view highlights SharePoint context, including list references.";

            resetButton.Height = saveButton.Height;
            previewButton.Height = resetButton.Height;

            #endregion

        }

        public TabPage GetTabPage()
        {
            return Tab;
        }
    }
}
