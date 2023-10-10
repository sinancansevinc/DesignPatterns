using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public class Ticket
    {
        public Severity Severity { get; set; }
    }

    public enum Severity
    {
        Low,
        Medium,
        High
    }
}
