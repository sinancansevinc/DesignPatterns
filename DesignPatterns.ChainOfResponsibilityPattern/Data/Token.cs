using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Data
{
    public class Token
    {
        public string Value { get; set; }
        public string[] Roles { get; set; }
        public bool IsExpired { get; set; }

    }
}
