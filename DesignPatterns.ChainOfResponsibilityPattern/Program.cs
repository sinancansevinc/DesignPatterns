/* 
 Our scenario is , customer needs to has token and if token has not expired , 
 we are going to control if product has stock, and then confirmed the order
 */

using DesignPatterns.ChainOfResponsibilityPattern.Data;
using DesignPatterns.ChainOfResponsibilityPattern.Handlers;
using DesignPatterns.ChainOfResponsibilityPattern.HandlersV2;

//V1 Example 

//Behavioral Pattern

Handler authentication = new AuthenticationHandler();
Handler authorization = new AuthorizationHandler();
Handler validation = new ValidationHandler();
Handler controller = new ControllerHandler();

authentication.SetSuccessor(authorization);
authorization.SetSuccessor(validation);
validation.SetSuccessor(controller);


var request = new Request
{
    Token = new Token
    {
        IsExpired = false,
        Roles = new List<string> { "Customer" }.ToArray(),
        Value = "token"
    },
    Order = new Order
    {
        InStock = true,
        Id = 1,
        Price = 10
    }
};

Response response = authentication.ProcessRequest(request);
if (response.IsSuccess)
    Console.ForegroundColor = ConsoleColor.Green;
else
    Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine(response.Message);
Console.ResetColor();
Console.ReadLine();

//V2 EXAMPLE

//var level1SupportHandler = new Level1SupportHandler();
//var level2SupportHandler = new Level2SupportHandler();
//var level3SupportHandler = new Level3SupportHandler();

//level1SupportHandler.SetNextHandler(level2SupportHandler);
//level2SupportHandler.SetNextHandler(level3SupportHandler);

//var ticket1 = new Ticket { Severity = Severity.Low };
//var ticket2 = new Ticket { Severity = Severity.Medium };
//var ticket3 = new Ticket { Severity = Severity.High };

//level1SupportHandler.HandleTicket(ticket1);
//level1SupportHandler.HandleTicket(ticket2);
//level1SupportHandler.HandleTicket(ticket3);