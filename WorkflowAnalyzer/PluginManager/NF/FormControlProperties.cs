using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PluginManager.NF
{
    [XmlInclude(typeof(BaseBindableFormControlProperties))]
    [XmlInclude(typeof(BaseContainerFormControlProperties))]
    [XmlInclude(typeof(BaseFormControlProperties))]
    [XmlInclude(typeof(BooleanFormControlProperties))]
    [XmlInclude(typeof(ButtonFormControlProperties))]
    [XmlInclude(typeof(CalculationFormControlProperties))]
    [XmlInclude(typeof(CascadingFormControlProperties))]
    [XmlInclude(typeof(ChoiceFormControlProperties))]
    [XmlInclude(typeof(DateTimeFormControlProperties))]
    [XmlInclude(typeof(FrameFormControlProperties))]
    [XmlInclude(typeof(GeoLocationFormControlProperties))]
    [XmlInclude(typeof(HtmlFormControlProperties))]
    [XmlInclude(typeof(HyperlinkColumnFormControlProperties))]
    [XmlInclude(typeof(ImageFormControlProperties))]
    [XmlInclude(typeof(LabelFormControlProperties))]
    [XmlInclude(typeof(LineFormControlProperties))]
    [XmlInclude(typeof(MultiLineTextBoxFormControlProperties))]
    [XmlInclude(typeof(PanelFormControlProperties))]
    [XmlInclude(typeof(PeoplePickerFormControlProperties))]
    [XmlInclude(typeof(RepeaterDataFormControlProperties))]
    [XmlInclude(typeof(RepeaterDataItemFormControlProperties))]
    [XmlInclude(typeof(RepeaterDataItemColumnFormControlProperties))]
    [XmlInclude(typeof(RepeaterFormControlProperties))]
    [XmlInclude(typeof(TextBoxFormControlProperties))]
    [XmlInclude(typeof(UnsupportedFormControlProperties))]
    [XmlInclude(typeof(ChangeContentTypeFormControlProperties))]
    [XmlInclude(typeof(ExternalDataColumnControlProperties))]
    [XmlInclude(typeof(ListItemFormControlProperties))]
    [XmlInclude(typeof(SharePointLookupFormControlProperties))]
    [XmlInclude(typeof(ListViewFormControlProperties))]
    [XmlInclude(typeof(TaxonomyFormControlProperties))]
    [XmlInclude(typeof(ViewWorkflowFormControlProperties))]
    [XmlInclude(typeof(AttachmentFormControlProperties))]
    public class FormControlProperties
    {
        [XmlAttribute("type")]
        public string Type;

        [XmlArrayItem("LinePosition", typeof(string))]
        [XmlArray("Border")]

        public List<string> Border;

        public string BorderColor;

        public string BorderStyle;

        public int BorderWidth;
        
        public bool CanResizeAtRuntime;

        public string ControlVersion;

        public string CssClass;

        public string DisplayName;

        public string FormControlTypeUniqueId;

        public string FormType;

        public bool InRepeater;

        //public List<string> InsertReferences;

        //public List<string> InternalPropertyBag;

        public bool IsDirty;

        public bool IsLocked;

        public bool IsVisible;

        public int PaddingWidth;

        public int TabIndex;

        public string UniqueId;

        public string VariableSource;

        public string VerticalAlign;

        public string BackgroundColor;

        public string AlternateText;

        public string HorizontalWidth;

        public string ImageUrl;

        public string Name;

        public string VerticalHeight;

        public string ControlCssClass;

        public string ControlMode;

        public string CustomErrorMessage;

        public string CustomvalidationFunction;

        public string DataField;

        public string DataFieldDisplayName;

        public bool ExposeClientIdAsJavaScriptVariable;

        public string ExposedClientIdJavaScriptVariable;

        public string HelpText;

        public string HelpTextSet;

        public bool IsEnabled;

        public bool IsRequired;

        public string RequiredErrorMessage;

        public bool UseCustomValidation;

        public string CompareErrorMessage;

        public string CompareOperator;

        public string CompareTo;

        public string ControlToCompare;

        public string DefaultValue;

        public string DefaultValueSource;

        public string DialogTitle;

        public int MaximumEntities;

        public bool MultiSelect;

        public bool MultiSelectChanged;

        public string PickerDialogToolTip;

        public string SharePointGroup;

        public bool UseCompareValidation;

        public string ValueToCompare;
    }
    public class AttachmentFormControlProperties : FormControlProperties { }
    public class BaseBindableFormControlProperties : FormControlProperties { }
    public class BaseContainerFormControlProperties : FormControlProperties { }
    public class BaseFormControlProperties : FormControlProperties { }
    public class BooleanFormControlProperties : FormControlProperties { }
    public class ButtonFormControlProperties : FormControlProperties { }
    public class CalculationFormControlProperties : FormControlProperties { }
    public class CascadingFormControlProperties : FormControlProperties { }
    public class ChoiceFormControlProperties : FormControlProperties { }
    public class DateTimeFormControlProperties : FormControlProperties { }
    public class FrameFormControlProperties : FormControlProperties { }
    public class GeoLocationFormControlProperties : FormControlProperties { }
    public class HtmlFormControlProperties : FormControlProperties { }
    public class HyperlinkColumnFormControlProperties : FormControlProperties { }
    public class ImageFormControlProperties : FormControlProperties { }
    public class LabelFormControlProperties : FormControlProperties { }
    public class LineFormControlProperties : FormControlProperties { }
    public class MultiLineTextBoxFormControlProperties : FormControlProperties { }
    public class PanelFormControlProperties : FormControlProperties { }
    public class PeoplePickerFormControlProperties : FormControlProperties { }
    public class RepeaterDataFormControlProperties : FormControlProperties { }
    public class RepeaterDataItemFormControlProperties : FormControlProperties { }
    public class RepeaterDataItemColumnFormControlProperties : FormControlProperties { }
    public class RepeaterFormControlProperties : FormControlProperties { }
    public class TextBoxFormControlProperties : FormControlProperties { }
    public class UnsupportedFormControlProperties : FormControlProperties { }
    public class ChangeContentTypeFormControlProperties : FormControlProperties { }
    public class ExternalDataColumnControlProperties : FormControlProperties { }
    public class ListItemFormControlProperties : FormControlProperties { }
    public class SharePointLookupFormControlProperties : FormControlProperties { }
    public class ListViewFormControlProperties : FormControlProperties { }
    public class TaxonomyFormControlProperties : FormControlProperties { }
    public class ViewWorkflowFormControlProperties : FormControlProperties { }
}
