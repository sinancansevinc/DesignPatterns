using DesignPatterns.ChainOfResponsibilityPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class AuthenticationHandler : Handler
    {
        public override Response ProcessRequest(Request request)
        {
            if (request.Token.IsExpired || String.IsNullOrEmpty(request.Token.Value))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Token is expired or invalid"
                };
            }

            else
            {
                return this.Successor.ProcessRequest(request);
            }

        }
    }
}
