using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xmlserialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            //personinfo pi = new personinfo("martin", 22);
            searialise s = new searialise();
            // s.savedata(pi);
            personinfo pnew = new personinfo();
            pnew.showdata();
            pnew = s.getdata();
            pnew.showdata();

        }
    }
}
