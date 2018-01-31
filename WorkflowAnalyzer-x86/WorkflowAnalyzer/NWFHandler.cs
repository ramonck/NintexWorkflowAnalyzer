
using System.Xml;

namespace WorkflowAnalyzer
{
    internal class NWFHandler
    {
        private static XmlDocument _nwfXmlDocument;
        private static XmlDocument _nwfXmlInternalDocument;
        private static XmlDocument _nwfXmlModified;
        private static int _nwfFilesize;

        /// <summary>
        /// NWF External and Internal XML
        /// </summary>
        public XmlDocument NwfXmlDocument
        {
            get { return _nwfXmlDocument; }
            protected set { _nwfXmlDocument = value; }
        }

        /// <summary>
        /// NWF Internal XML
        /// </summary>
        public XmlDocument NwfXmlInternalDocument
        {
            get { return _nwfXmlInternalDocument; }
            protected set { _nwfXmlInternalDocument = value; }
        }

        /// <summary>
        /// NWF XML Modified by Editor
        /// </summary>
        public XmlDocument NwfXmlModifiedByEditor
        {
            get { return _nwfXmlModified; }
            internal set { _nwfXmlModified = value; }
        }

        /// <summary>
        /// Nwf File Size in Kilobytes.
        /// </summary>
        public int NwfFileSize
        {
            get { return _nwfFilesize/1024; }
            protected set { _nwfFilesize = value; }

        }
    }
}
