using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern.Data
{
    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
    }
}
