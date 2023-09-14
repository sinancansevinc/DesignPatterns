/*
Pros:
    - Single instance
    - Global access
    - Create when requested. After the first request , object will be created.

Cons:
    - UnitTest is difficult when mocking
*/

using DesignPatterns.SingletonPattern;

var cities = await FakeCities.Instance.GetCities();

var anotherCities = await FakeCities.Instance.GetCity();

Console.ReadLine();
//When another service calling , it is created again and again and it took 4 second.