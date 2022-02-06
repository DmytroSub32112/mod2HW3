using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    public class ChocolateCandies : Candy
    {
        public virtual void Messege()
        {
            Console.WriteLine("I have Chocolate");
        }
    }
}
