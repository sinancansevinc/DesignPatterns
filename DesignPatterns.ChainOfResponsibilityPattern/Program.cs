/* 
 Our scenario is , customer needs to has token and if token has not expired , 
 we are going to control if product has stock, and then confirmed the order
 */

using DesignPatterns.ChainOfResponsibilityPattern.Data;
using DesignPatterns.ChainOfResponsibilityPattern.Handlers;

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
        Roles = new List<string> { "Customer"}.ToArray(),
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