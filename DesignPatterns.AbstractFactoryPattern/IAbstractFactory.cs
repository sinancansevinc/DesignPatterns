using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IFootball GetFootballClub(string captain, double value);
        IBasketball GetBasketballClub(string league, int numberOfPlayers);
    }

    public class GalatasarayFactory : IAbstractFactory
    {
        public IBasketball GetBasketballClub(string league, int numberOfPlayers)
        {
            return new GalatasarayBasketballClub(league, numberOfPlayers);
        }

        public IFootball GetFootballClub(string captain, double value)
        {
            return new GalatasarayFootballClub(captain, value);
        }
    }

    public class RealMadridFactory : IAbstractFactory
    {
        public IBasketball GetBasketballClub(string league, int numberOfPlayers)
        {
            return new RealMadridBasketballClub(league, numberOfPlayers);
        }

        public IFootball GetFootballClub(string captain, double value)
        {
            return new RealMadridFootballCLub(captain, value);
        }
    }
}
