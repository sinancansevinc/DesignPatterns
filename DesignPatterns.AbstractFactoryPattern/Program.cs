using DesignPatterns.AbstractFactoryPattern;

IAbstractFactory galatasarayFactory = new GalatasarayFactory();
IAbstractFactory realMadridFactory = new RealMadridFactory();


IFootball galatasaray = galatasarayFactory.GetFootballClub("Sino", 25000000000);
IFootball realMadrid = realMadridFactory.GetFootballClub("Vini Jr", 100000000000);


IBasketball galatasarayBasket = galatasarayFactory.GetBasketballClub("Eurocup", 12);
IBasketball realMadridBasket = galatasarayFactory.GetBasketballClub("Euroleague", 12);


Console.WriteLine("Galatasaray Football Club Captain: " + galatasaray.GetCaptain());

Console.ReadLine();


