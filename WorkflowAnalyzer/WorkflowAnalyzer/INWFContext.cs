

using PluginManager.NWF;
using System.Xml;

namespace WorkflowAnalyzer
{
    internal interface INWFContext
    {
        XmlDocument NWFXmlDocument { get; set; }

        XmlDocument NWFXmlInternalDocument { get; set; }

        XmlDocument NWFXmlModified { get; set; }

        NintexWorkflowDocument NintexWorkflowExternalContext { get; }

        ExportedWorkflow NintexWorkflowInternalContext { get; }

        int NWFFileSize();

        string AssociatedListName();

        string WorkflowType();

        int ActionCount();

        bool UsesEventReceiver();

        bool HasLogInLoop();

        bool IsLoggingProgressDataInLoop();

        bool StartsOnCreateEvent();

        bool StartsOnModifiedEvent();

        int VersionOfNintexWorkflow();

        bool NWVersionIsCurrent();

        bool HasCorrectTiming();

        bool HasPauseStartAction();

        bool HandlesBatching();

        bool NwfTooLarge();

        bool HasRecursiveConfiguration();

        bool UsingStoredCredentials();

        bool CallWebServiceUsesTokenEncoding();
    }
}
