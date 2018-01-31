

using System.Xml;

namespace WorkflowAnalyzer
{
    internal interface INWFContext
    {
        XmlDocument NWFXmlDocument { get; set; }

        XmlDocument NWFXmlInternalDocument { get; set; }

        XmlDocument NWFXmlModified { get; set; }

        int NWFFileSize();

        string AssociatedListName();

        string WorkflowType();

        int ActionCount();

        bool UsesEventReceiver();

        bool StartsOnCreateEvent();

        bool StartsOnModifiedEvent();

        int VersionOfNintexWorkflow();

        bool NWVersionIsCurrent();

        bool HasCorrectTiming();

        bool HasPauseStartAction();

        bool HandlesBatching();

        bool NwfTooLarge();
    }
}
