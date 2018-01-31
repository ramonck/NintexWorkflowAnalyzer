using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Windows;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Integration;
using PluginManager.NWF;
using WorkflowAnalyzer.WPF.Controls;
using System.Windows.Controls;


namespace WorkflowAnalyzer.GraphicalViewR2
{
    [Export(typeof(IExternalExtension))]
    public class Main : ExternalTabPluginBase
    {
        public override void Execute()
        {
            ExternalTabPage.Text = "Graphical R2";
            ElementHost host = new ElementHost();
            host.Dock = System.Windows.Forms.DockStyle.Top;
            host.AutoSize = true;
            
            StackPanel panel = new StackPanel();

            panel.CanVerticallyScroll = true;

            panel.FlowDirection = FlowDirection.LeftToRight;

            foreach (NWActionConfig config in PluginHelper.NintexWorkflowInternalContext.Configurations.ActionConfigs)
            {
                panel.Children.Add(new WFAction(config));
            }

            host.Child = panel;
            ExternalTabPage.AutoScroll = true;
            
            ExternalTabPage.Controls.Add(host);

            
        }
    }
}
