
//Creational Pattern

using DesignPatterns.FactoryPattern;




IConsole ps5 = ConsoleFactory.BuyConsole("Ps5", "Purple", 1000);
IConsole xbox = ConsoleFactory.BuyConsole("XboxSeriesX", "Black", 500);

Console.WriteLine($"PS5 color is {ps5.getColor()} and its memory is {ps5.getMemory()}");
Console.WriteLine($"XBOX color is {xbox.getColor()} and its memory is {xbox.getMemory()}");

Console.ReadLine();