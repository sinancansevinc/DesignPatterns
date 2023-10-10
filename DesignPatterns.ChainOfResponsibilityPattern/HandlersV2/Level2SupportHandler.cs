using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public class Level2SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Medium;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 2 support handled the ticket");
        }
    }
}
