using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAdo
{
    public class Details
    {
        public int Dnum { get; set; }
        public string Dname { get; set; }
        public int Dprice { get; set; }

        public Details() {}

        public Details(int Dnum, string Dname, int Dprice)
        {
            this.Dnum = Dnum;
            this.Dname = Dname;
            this.Dprice = Dprice;
        }
    }
}
