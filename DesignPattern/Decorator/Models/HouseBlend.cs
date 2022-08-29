using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Models
{
    internal class HouseBlend : Beverage
    {
        public override void Cost()
        {
            Console.WriteLine("HouseBlend cost 10");
        }
    }
}
