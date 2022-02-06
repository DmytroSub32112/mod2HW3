using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    public class Consider : IConsider
    {
        public int ConsiderCalories(int weith, int calories)
        {
            return weith * calories / 100;
        }
    }
}
