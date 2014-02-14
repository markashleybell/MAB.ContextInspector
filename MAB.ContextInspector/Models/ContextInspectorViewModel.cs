using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAB.ContextInspector.Models
{
    public class ContextInspectorViewModel
    {
        public Dictionary<string, ContextInspectorItemInfo> CacheVariables { get; set; }
        public Dictionary<string, ContextInspectorItemInfo> SessionVariables { get; set; }
        public Dictionary<string, ContextInspectorItemInfo> ApplicationVariables { get; set; }
    }
}
