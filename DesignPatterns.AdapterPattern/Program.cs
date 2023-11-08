// See https://aka.ms/new-console-template for more information


//Structural Pattern

using DesignPatterns.AdapterPattern;

Fax fax = new Fax(327, "Internet connection down");

var errors = new List<IError>()
{
    new DbError(729, "Storage is full"),
    new ServiceError(401, "Authentication failed"),
    new FaxAdapter(fax)
};


foreach (var item in errors)
{
    item.SendMail();
}


Console.ReadLine();

