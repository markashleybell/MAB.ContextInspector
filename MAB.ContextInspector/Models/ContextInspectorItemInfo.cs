using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAB.ContextInspector.Models
{
    public class ContextInspectorItemInfo
    {
        public string FullTypeName { get; set; }
        public string ShortTypeName { get; set; }
        public object Item { get; set; }
    }
}
