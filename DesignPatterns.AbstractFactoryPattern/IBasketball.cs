using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public interface IBasketball
    {
        string GetLeague();
        int GetNumberOfPlayers();
    }

    public class GalatasarayBasketballClub : IBasketball
    {
        private string league;
        private int numberOfPlayers;

        public GalatasarayBasketballClub(string league, int numberOfPlayers)
        {
            this.league = league;
            this.numberOfPlayers = numberOfPlayers;
        }

        public string GetLeague()
        {
            return league;
        }

        public int GetNumberOfPlayers()
        {
            return numberOfPlayers;
        }
    }

    public class RealMadridBasketballClub : IBasketball
    {
        private string league;
        private int numberOfPlayers;

        public RealMadridBasketballClub(string league, int numberOfPlayers)
        {
            this.league = league;
            this.numberOfPlayers = numberOfPlayers;
        }

        public string GetLeague()
        {
            return league;
        }

        public int GetNumberOfPlayers()
        {
            return numberOfPlayers;
        }
    }
}
