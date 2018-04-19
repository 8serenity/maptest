using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maptest
{
    public class Map
    {
        public int Id { get; set; }
        ICollection<Route> Routes { get; set; }
    }
}
