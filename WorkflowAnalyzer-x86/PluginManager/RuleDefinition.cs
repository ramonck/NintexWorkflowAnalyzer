
using System;
using System.Xml.Linq;

namespace PluginManager
{
    /// <summary>
    /// Rule Definition class for use with Rule Definition plug-ins.
    /// </summary>
     public class RuleDefinition
    {
        /// <summary>
        /// Name of Rule.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of Rule.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Category of rule.
        /// 0 - Informational
        /// 1 - Warning
        /// 2 - Problematic
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// URL to article for more information.
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Indicates whether rule validated.
        /// </summary>
        public bool Valid { get; set; }

        /// <summary>
        /// Additional parameters or information to provide.
        /// </summary>
        public XElement[] Parameters { get; set; }
    }
}
