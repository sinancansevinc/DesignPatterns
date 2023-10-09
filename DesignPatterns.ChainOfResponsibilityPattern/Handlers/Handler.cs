using DesignPatterns.ChainOfResponsibilityPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract Response ProcessRequest(Request request);

    }
}
