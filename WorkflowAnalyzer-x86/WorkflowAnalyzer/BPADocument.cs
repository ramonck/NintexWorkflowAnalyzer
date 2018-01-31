
using System.Xml.Linq;
using PluginManager;

namespace WorkflowAnalyzer
{
    internal class BpaDocument
    {
        private NWFContext _nwfContext;

        public BpaDocument(NWFContext nwfContext)
        {
            BpaXmlDocument = new XDocument();
            AddRootElement();
        }

        private void AddRootElement()
        {
            BpaXmlDocument.Add(new XElement("Checks"));
        }

        private XDocument _bpaXmlDocument = new XDocument();

        public XDocument BpaXmlDocument {
            get { return _bpaXmlDocument; }
            set { _bpaXmlDocument = value; }
        }

        public void AddDefinititonToBpa(RuleDefinition definition)
        {
            XElement root = BpaXmlDocument.Element("Checks");

            XElement definitionElement = new XElement("Check");
            definitionElement.Add(new XAttribute("Category", definition.Category));
            definitionElement.Add(new XAttribute("Name", definition.Name));
            definitionElement.Add(new XAttribute("Pass", definition.Valid));
            definitionElement.Add(new XAttribute("Url", definition.Url));
            definitionElement.Add(new XAttribute("Description", definition.Description));
            definitionElement.Add(definition.Parameters);

            root.Add(definitionElement);
        }

        public void PopulateDefaultDefinitions()
        {
            XElement RootElement = new XElement("Checks",
            #region VersionCheck
 new XElement("Check",
        new XAttribute("Name", "NWVersion"),
        new XAttribute("Pass", _nwfContext.NWVersionIsCurrent()),
    new XElement("Parameter", "Version of Nintex Workflow: " + _nwfContext.VersionOfNintexWorkflow())),
            #endregion
            #region TimingCheck
 new XElement("Check",
        new XAttribute("Name", "Timing"),
        new XAttribute("Pass", _nwfContext.HasCorrectTiming()),
        new XElement("Parameter", "Uses Event Receiver: " + _nwfContext.UsesEventReceiver()),
        new XElement("Parameter", "Uses Item Creation Receiver: " + _nwfContext.StartsOnCreateEvent()),
        new XElement("Parameter", "Uses Item Modification Receiver: " + _nwfContext.StartsOnModifiedEvent()),
        new XElement("Parameter", "Has Delay as First Action: " + _nwfContext.HasPauseStartAction())),
            #endregion
            #region BatchingCheck
 new XElement("Check",
        new XAttribute("Name", "Batching"),
        new XAttribute("Pass", _nwfContext.HandlesBatching()),
        new XElement("Parameter", "Handles Batched Actions with Commit Pending Change Actions: " + _nwfContext.HandlesBatching())),
            #endregion
            #region NWFFileSizeCheck
 new XElement("Check",
        new XAttribute("Name", "Filesize"),
        new XAttribute("Pass", !_nwfContext.NwfTooLarge()),
        new XElement("Parameter", "Workflow size is under 500kb: " + !_nwfContext.NwfTooLarge()),
        new XElement("Parameter", "Workflow size: " + _nwfContext.NWFFileSize() + "kb")));

            #endregion

            BpaXmlDocument.Add(RootElement);
        }
    }
}
