using DesignPatterns.ChainOfResponsibilityPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class AuthorizationHandler : Handler
    {
        public override Response ProcessRequest(Request request)
        {
            if (!request.Token.Roles.Contains("Customer"))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Authorization failed"
                };
            }

            else
            {
                return this.Successor.ProcessRequest(request);
            }

        }
    }
}
