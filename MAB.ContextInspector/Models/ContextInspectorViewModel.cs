using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAB.ContextInspector.Models
{
    public class ContextInspectorViewModel
    {
        public Dictionary<string, Tuple<string, string>> SessionVariables { get; set; }
        public Dictionary<string, Tuple<string, string>> ApplicationVariables { get; set; }
    }
}
