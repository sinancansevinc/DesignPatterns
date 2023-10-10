using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public interface ISupportHandler
    {
        void SetNextHandler(ISupportHandler handler);
        void HandleTicket(Ticket ticket);
    }
}
