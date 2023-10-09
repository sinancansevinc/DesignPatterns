using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Data
{
    public class Request
    {
        public Token Token { get; set; }
        public Order Order { get; set; }
    }
}
