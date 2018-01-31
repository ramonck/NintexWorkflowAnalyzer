
using System;
using System.Xml.Linq;

namespace WorkflowAnalyzer
{
    internal interface IBpaDefinition
    {
        string Name();

        string Description();

        string Category();

        Uri Url();

        bool Valid();

        XElement[] Parameters();

    }
}
