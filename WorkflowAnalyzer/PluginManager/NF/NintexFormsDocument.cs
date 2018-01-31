using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PluginManager.NF
{
    [Serializable, XmlRoot("Form")]
    public class NintexFormsDocument
    {
        public string Bold;

        public string FontColor;

        public string FontFamily;

        public string FontFamilyId;

        public string FontSize;

        public string FontSizeItemId;

        [XmlElement("AddListFormWebPartSubmitMessage")]
        public bool AddListFormWebPartSubmitMessage;

        [XmlElement("Category")]
        public string Category;

        [XmlElement("Css")]
        public string Css;

        [XmlArrayItem("string", typeof(string))]
        [XmlArray("CssUrls")]
        public List<string> CssUrls;

        [XmlElement("Description")]
        public string Description;

        [XmlArrayItem("FormControlProperties", typeof(FormControlProperties))]
        [XmlArray("FormControls")]
        public List<FormControlProperties> FormControls;
        
        [XmlElement("FormCssClass")]
        public string FormCssClass;

        [XmlArrayItem("FormLayout", typeof(FormLayout))]
        [XmlArray("FormLayouts")]
        public List<FormLayout> FormLayouts;

        [XmlElement("FormType")]
        public string FormType;

        [XmlElement("HideConfirmSuccessDialog")]
        public bool HideConfirmSuccessDialog;

        [XmlElement("Icon")]
        public string Icon;

        [XmlElement("Id")]
        public string Id;

        [XmlElement("ListFormWebPartSubmitMessage")]
        public string ListFormWebPartSubmitMessage;

        [XmlElement("LiveSettings")]
        public NFLiveSettings LiveSettings;

        [XmlElement("Name")]
        public string Name;

        [XmlElement("Rules")]
        public List<Rule> Rules;

        [XmlElement("Script")]
        public string Script;

        [XmlElement("ScriptUrls")]
        public List<string> ScriptUrls;

        [XmlElement("ShowGridLines")]
        public bool ShowGridLines;

        [XmlElement("TimeZone")]
        public string TimeZone;

        [XmlElement("UseDefaults")]
        public bool UseDefaults;

        [XmlElement("UseServerTimeZone")]
        public bool UseServerTimeZone;

        //UserFormVariables

        [XmlElement("Version")]
        public string Version;

        [XmlElement("WakeUpWfForVars")]
        public bool WakeUpWfForVars;

    }
}
