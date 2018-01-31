
using System.Collections.Generic;
using System.Xml;
using PluginManager.NWF;
using PluginManager.SupportPackage;
using SupportPackage;
using ULSPack;

namespace WorkflowAnalyzer
{
    /// <summary>
    /// Provides one way communication from Nintex Workflow Analyzer to plug-ins.
    /// </summary>
    public static class PluginHelper
    {

        #region NWF
        /// <summary>
        /// Returns loaded NWF document as XML.
        /// </summary>
        public static XmlDocument NwfXmlDocument { get; set; }

        /// <summary>
        /// Returns internal XML from the loaded NWF document.
        /// </summary>
        public static XmlDocument NwfXmlInternalDocument { get; set; }

        /// <summary>
        /// Returns external XML from the loaded NWF document.
        /// </summary>
        public static XmlDocument NwfXmlExternalDocument { get; set; }

        /// <summary>
        /// Returns loaded NWF (from editor) document as XML.
        /// </summary>
        public static XmlDocument NwfXmlModifiedByEditor { get; set; }

        /// <summary>
        /// List Associated with Workflow.
        /// </summary>
        public static string AssociatedListName { get; set; }

        /// <summary>
        /// Workflow Type Site/List
        /// </summary>
        public static string WorkflowType { get; set; }

        /// <summary>
        /// Count of all activities in the workflow less sequence adapters.
        /// </summary>
        public static int ActionCount { get; set; }

        /// <summary>
        /// Count of all activities in the workflow.
        /// </summary>
        public static int RealActionCount { get; set; }

        /// <summary>
        /// Does the workflow start when a new item is created?
        /// </summary>
        public static bool StartsOnCreateEvent { get; set; }

        /// <summary>
        /// Does the workflow start when an item is modified?
        /// </summary>
        public static bool StartsOnModifiedEvent { get; set; }

        /// <summary>
        /// Does the workflow start when an item is created or modified?
        /// </summary>
        public static bool UsesEventReceiver { get; set; }

        /// <summary>
        /// Version of Nintex Workflow the export is from.
        /// </summary>
        public static int VersionOfNintexWorkflow { get; set; }

        /// <summary>
        /// Does the workflow correctly handle batched actions?
        /// </summary>
        public static bool HandlesBatching { get; set; }

        /// <summary>
        /// Does the workflow handle instantiation timing correctly?
        /// </summary>
        public static bool HandlesTiming { get; set; }

        /// <summary>
        /// Workflow filesize in Kb.
        /// </summary>
        public static int WorkflowSize { get; set; }

        /// <summary>
        /// Application installation directory.
        /// </summary>
        public static string ApplicationRootPath { get; set; }

        /// <summary>
        /// Application plugin directory.
        /// </summary>
        public static string PluginPath { get; set; }

        /// <summary>
        /// Application WebAssets directory.
        /// </summary>
        public static string WebAssetsPath { get; set; }

        /// <summary>
        /// Returns JQuery Assets with resolved paths in HTML.
        /// </summary>
        public static string JQueryLibrary { get; set; }

        public static string WorkflowTitle { get; set; }

        public static NintexWorkflowDocument NintexWorkflowExternalContext { get; internal set; }

        public static ExportedWorkflow NintexWorkflowInternalContext { get; internal set; }

        #endregion

        #region SupportPackage
        /// <summary>
        /// Farm summary loaded from Support Package File as XML.
        /// </summary>
        public static XmlDocument FarmSummaryXmlDocument { get; internal set; }

        /// <summary>
        /// Nintex product information loaded from Support Package File as XML;
        /// </summary>
        public static XmlDocument NintexProductsXmlDocument { get; internal set; }

        /// <summary>
        /// Farm summary loaded from Support Package File.
        /// </summary>
        public static FarmSummary FarmSummaryContext { get; internal set; }

        /// <summary>
        /// Nintex product information loaded from Support Package File.
        /// </summary>
        public static NintexProductData NintexProductDataContext { get; internal set; }

        /// <summary>
        /// ULS log loaded from Support Package File.
        /// </summary>
        public static string ULSLogs { get; internal set; }

        /// <summary>
        /// ULS Log loaded from Support Package File.
        /// </summary>
        public static List<IULSLogEntry> UlsLogEntries { get; internal set; } 

        #endregion

    }
}
