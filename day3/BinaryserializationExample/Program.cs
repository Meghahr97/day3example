using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryserializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //personinfo pi = new personinfo("clark", 53);
            //SearialiseData sd = new SearialiseData();
            //sd.SaveData(pi);

            SearialiseData sd = new SearialiseData();
            personinfo pi = new personinfo();
            pi.showdata();
            pi = sd.Getdata();
            pi.showdata();


        }
    }
}
