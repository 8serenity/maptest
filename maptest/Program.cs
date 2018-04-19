using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maptest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MapContext())
            {
                context.Cars.ToList();
            }
        }
    }
}
