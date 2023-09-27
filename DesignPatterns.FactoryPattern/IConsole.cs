using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public interface IConsole
    {
        string getColor();
        int getMemory();
    }

    class Ps5 : IConsole
    {
        private string color;
        private int memory;

        public Ps5(string color, int memory)
        {
            this.color = color;
            this.memory = memory;
        }
        public string getColor()
        {
            return color;
        }

        public int getMemory()
        {
            return memory;
        }
    }

    class XboxSeriesX : IConsole
    {
        private string color;
        private int memory;

        public XboxSeriesX(string color, int memory)
        {
            this.color = color;
            this.memory = memory;
        }
        public string getColor()
        {
            return color;
        }

        public int getMemory()
        {
            return memory;
        }
    }
}
