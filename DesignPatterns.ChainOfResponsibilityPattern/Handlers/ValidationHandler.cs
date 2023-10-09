﻿using DesignPatterns.ChainOfResponsibilityPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class ValidationHandler : Handler
    {
        public override Response ProcessRequest(Request request)
        {
            if (!request.Order.InStock)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "No stock in order"
                };
            }
            else
            {
                return this.Successor.ProcessRequest(request);
            }
        }

    }

}
