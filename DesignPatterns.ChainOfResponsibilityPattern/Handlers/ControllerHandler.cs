﻿using DesignPatterns.ChainOfResponsibilityPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Handlers
{
    public class ControllerHandler : Handler
    {
        public override Response ProcessRequest(Request request)
        {
            return new Response
            {
                IsSuccess = true,
                Message = "Order successfully created"
            };
        }
    }
}
