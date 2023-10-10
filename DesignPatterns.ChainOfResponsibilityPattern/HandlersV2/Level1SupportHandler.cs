using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public class Level1SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Low;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 1 support handled the ticket");
        }
    }
}
