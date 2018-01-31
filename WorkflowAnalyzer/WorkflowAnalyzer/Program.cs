using System;
using System.Windows.Forms;
using WorkflowAnalyzer.Forms;

namespace WorkflowAnalyzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            //System.Diagnostics.Debugger.Launch();
            try
            {

                if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData != null)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new WfaMain(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData));
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new WfaMain());
                }
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.ToString(), "Workflow Analyzer encountered an error"); //Startup Debugger
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WfaMain());
            }
        }


    }
}
