using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public class Level3SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.High;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 3 Support handles the ticket.");

        }
    }
}
