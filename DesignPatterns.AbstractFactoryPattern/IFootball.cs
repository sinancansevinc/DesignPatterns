using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public interface IFootball
    {
        string GetCaptain();
        double GetValue();
    }

    public class GalatasarayFootballClub : IFootball
    {
        private string captain;
        private double value;

        public GalatasarayFootballClub(string captain,double value)
        {
            this.captain = captain;
            this.value = value;
        }

        public string GetCaptain()
        {
            return captain;
        }

        public double GetValue()
        {
            return value;
        }
    }

    public class RealMadridFootballCLub : IFootball
    {
        private string captain;
        private double value;

        public RealMadridFootballCLub(string captain,double value)
        {
            this.captain = captain;
            this.value = value;
        }

        public string GetCaptain()
        {
            return captain;
        }

        public double GetValue()
        {
            return value;
        }
    }
}
