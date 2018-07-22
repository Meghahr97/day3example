using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate void SMS(string m);
        static void Main(string[] args)
        {
            SchoolGroup sg = new SchoolGroup();
            CollegeGroup cg = new CollegeGroup();
            DeloitteGroup dg = new DeloitteGroup();

            SMS sms = sg.Message;
            sms += cg.Message;
            sms += dg.Message;
            sms("good afternoon");

            sms -= sg.Message;
            sms -= dg.Message;
            sms("alumni mweeting in the college");
            sms += dg.Message;
            sms -= cg.Message;
            sms("dot net class starts from monday");
        }
    }
}
