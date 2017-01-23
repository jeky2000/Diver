using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    public class Tournament
    {
        public string Name { get; set; }
        public string date { get; set; }
        public string location { get; set; }
        public List<judge> judges { get; set; }
        public List<hoppare> hopparelist { get; set; }

        public Tournament()
        {
            judges = new List<judge>();
            hopparelist = new List<hoppare>();
        }
        

    }
}
