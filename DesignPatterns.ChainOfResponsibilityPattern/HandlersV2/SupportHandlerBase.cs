using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.HandlersV2
{
    public abstract class SupportHandlerBase : ISupportHandler
    {
        private ISupportHandler _nextHandler;
        public void HandleTicket(Ticket ticket)
        {
            if (CanHandleTicket(ticket))
            {
                Handle(ticket);
            }

            else if (_nextHandler is not null)
            {
                _nextHandler.HandleTicket(ticket);
            }

            else
            {
                Console.WriteLine("Ticket cannot be handled");
            }

        }

        public void SetNextHandler(ISupportHandler handler)
        {
            _nextHandler = handler;
        }

        protected abstract bool CanHandleTicket(Ticket ticket);
        protected abstract void Handle(Ticket ticket);
    }
}
