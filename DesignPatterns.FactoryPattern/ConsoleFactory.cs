using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class ConsoleFactory
    {
        public static IConsole BuyConsole(string brand, string color, int memory)
        {
            IConsole console;

            if (brand.Equals("Ps5"))
            {
                console = new Ps5(color, memory);
            }

            else if (brand == "XboxSeriesX")
            {
                console = new XboxSeriesX(color, memory);
            }

            else
            {
                throw new Exception($"There is no console named {brand}");
            }

            return console;
        }
    }
}
