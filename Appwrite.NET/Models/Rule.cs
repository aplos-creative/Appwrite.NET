using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
    public class Rule
    {
        public string Label { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Default { get; set; }
        public bool Required { get; set; }
        public bool Array { get; set; }
    }
}
