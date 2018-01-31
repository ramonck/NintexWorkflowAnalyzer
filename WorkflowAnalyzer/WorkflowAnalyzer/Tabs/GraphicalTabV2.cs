using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginManager.NWF;
using WorkflowAnalyzer.Controls;

namespace WorkflowAnalyzer.Tabs
{
    public class GraphicalTabV2 : ITabContext
    {
        public TabPage Tab { get; set; }
        public string TabTitle { get; set; }
        public Control ChildControl { get; set; }
        private FlowLayoutPanel _flowLayoutPanel;
        private Queue<NWActionConfig> _actionQueue;
        private Label _progressLabel = new Label();
        private double _progress = 0;
        private double _newActionCount = PluginHelper.RealActionCount;
        private string CurrentActionType;
        private object _lock = new object();

        public GraphicalTabV2(string title)
        {
            TabTitle = title;
            InitializeTab();
            InitializeChildControl();
        }

        public void InitializeTab()
        {
            Tab = new TabPage();
            Tab.Text = TabTitle;
        }

        private void ActionProcessor()
        {
                while (_actionQueue.Count > 0)
                {
                    NWActionConfig actionConfig = _actionQueue.Dequeue();
                    CurrentActionType = actionConfig.Type;

                    /*lock (_lock)
                    {
                        _newActionCount--;
                        IncrementProgress();
                    }*/
                    

                    TableLayoutPanel panel = new TableLayoutPanel();

                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    //panel.BackColor = Color.DarkOliveGreen;
                    panel.AutoSize = true;
                    panel.Anchor = AnchorStyles.None;
                    _flowLayoutPanel.Controls.Add(panel);

                    ActionHandler(actionConfig, panel);
                }
        }

        private void ActionHandler(NWActionConfig actionConfig, TableLayoutPanel parentPanel)
        {
            Queue<NWActionConfig> actionQueue;

            if (actionConfig.ChildActivities.Count > 0)
            {
                    ActionHandler(actionConfig, new TableLayoutPanel(), parentPanel); 
            }
            else
            {
                ActionIcon actionIcon = new ActionIcon(actionConfig);
                actionIcon.Anchor = AnchorStyles.None;

                if (parentPanel.InvokeRequired)
                {
                    parentPanel.Invoke((MethodInvoker) delegate
                    {
                        parentPanel.Controls.Add(actionIcon);
                    });
                }
                else
                {
                    parentPanel.Controls.Add(actionIcon);
                }

                 
            }
        }

        private void ActionHandler(NWActionConfig actionConfig, TableLayoutPanel panel, TableLayoutPanel parentPanel)
        {
            Queue<NWActionConfig> actionQueue;

            #region Panel Config
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //panel.BackColor = Color.DarkOrange;
            panel.Anchor = AnchorStyles.Top;
            #endregion

            actionQueue = new Queue<NWActionConfig>();

                foreach (NWActionConfig childAction in actionConfig.ChildActivities)
                {
                    actionQueue.Enqueue(childAction);
                }

                ActionIcon actionIcon = new ActionIcon(actionConfig);
                
                actionIcon.Anchor = AnchorStyles.None;

                if (actionConfig.Type == "Nintex.Workflow.Activities.Adapters.WFSequenceAdapter" || actionConfig.Type == "Nintex.Workflow.Activities.Adapters.WFIfElseBranchAdapter" || actionConfig.Type == "Nintex.Workflow.Activities.Adapters.NWSwitchBranchAdapter" || actionConfig.Type == "Nintex.Workflow.Activities.Adapters.NWApproverBranchAdapter")
                {
                    //panel.Controls.Add(actionIcon);
                            if (parentPanel.RowCount == 0)
                            {
                                parentPanel.RowCount++;
                            }
                            parentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                            parentPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            parentPanel.Controls.Add(panel, parentPanel.ColumnCount, parentPanel.RowCount);
                            parentPanel.ColumnCount++;
                }
                else
                {
                    //panel.BackColor = Color.Chartreuse;
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    Panel headerPanel = new Panel();

                    //headerPanel.BackColor = Color.Red;
                    headerPanel.BorderStyle = BorderStyle.FixedSingle;

                    actionIcon.Dock = DockStyle.Fill;

                    headerPanel.Anchor = AnchorStyles.None;

                    headerPanel.Controls.Add(actionIcon);
                    headerPanel.Width = actionIcon.Width;
                    headerPanel.Height = actionIcon.Height;
                    

                    parentPanel.Controls.Add(headerPanel);
                    parentPanel.Controls.Add(panel);
                }

                while (actionQueue.Count > 0)
                {
                    NWActionConfig childActionConfig = actionQueue.Dequeue();
                    CurrentActionType = childActionConfig.Type;
                    ActionHandler(childActionConfig, panel);

                    lock (_lock)
                    {
                        --_newActionCount;
                        IncrementProgress();
                    }
                    
                }
                
        }

        public async void InitializeChildControl()
        {
            InitializeProgress();

            Tab.Controls.Add(_progressLabel);

            await Task.Run(() =>
            {
                FlowLayoutPanel topPanel = new FlowLayoutPanel();
                topPanel.FlowDirection = FlowDirection.TopDown;
                topPanel.WrapContents = false;
                topPanel.AutoScroll = true;
                _flowLayoutPanel = new FlowLayoutPanel();
                _actionQueue = new Queue<NWActionConfig>();

                List<NWActionConfig> actionConfigs = PluginHelper.NintexWorkflowInternalContext.Configurations.ActionConfigs;

                foreach (NWActionConfig actionConfig in actionConfigs)
                {
                    //Need to add some code to add the first action (variablesadapter) icon to the canvas.
                    if (actionConfig.Type != "Nintex.Workflow.Activities.Adapters.NWWorkflowVariablesAdapter")
                    {
                        _actionQueue.Enqueue(actionConfig);
                    }
                }

                ActionProcessor();

                _flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                //_flowLayoutPanel.BackColor = Color.Aqua;
                _flowLayoutPanel.Anchor = AnchorStyles.Top;
                _flowLayoutPanel.AutoScroll = true;

                _flowLayoutPanel.WrapContents = false;

                _flowLayoutPanel.AutoSize = true;
                _flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowOnly;

                //Need to figure out a way to center this.
                //topPanel.BackColor = Color.RoyalBlue;
                topPanel.Dock = DockStyle.Fill;


                topPanel.Controls.Add(_flowLayoutPanel);


                ChildControl = topPanel;
                //Tab.BackColor = Color.Black;
            });
                
                Tab.Controls.Clear();

                Tab.Controls.Add(ChildControl);

        }

        public TabPage GetTabPage()
        {
            return Tab;
        }

        private void InitializeProgress()
        {
            if (_progressLabel.InvokeRequired)
            {
                _progressLabel.Invoke((MethodInvoker) delegate
                {
                    SetProgress(true);
                });
            }

            else
            {
                SetProgress(true);
            }
        }

        private void SetProgress(bool setProperties)
        {
            //_progressLabel.Text = _progress + "% Processing - " + CurrentActionType;

            _progressLabel.Text = string.Format("{0:00.000%} Processing {1}", _progress, CurrentActionType);

            if (setProperties)
            {
                //_progressLabel.Font = new Font(FontFamily.GenericSerif, 50);
                _progressLabel.AutoSize = true;
                _progressLabel.Anchor = AnchorStyles.None;
            }
        }

        private void IncrementProgress()
        {
            //_progress = 100 - ((_actionQueue.Count % _actionCount)*10);

            _progress = (1 -(_newActionCount / PluginHelper.RealActionCount));

            if (_progress > 1)
            {
                
            }

            if (_progressLabel.InvokeRequired)
            {
                _progressLabel.Invoke((MethodInvoker) delegate
                {
                    SetProgress(false);
                });
            }
            else
            {
                SetProgress(false);
            }
        }

    }
}
