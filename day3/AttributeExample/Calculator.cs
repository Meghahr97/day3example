using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [Developerinfo(EmpId =123,name ="deepa",Dateofcreation ="07/17/2018",ProjName ="banking",Message ="this is used to perform calculation")]
    class Calculator
    {
        public int Add(int x,int y)
        {
            return (x + y);
        }
        public int sub(int x, int y)
        {
            return (x - y);
        }
        public int Mul(int x, int y)
        {
            return (x * y);
        }
        public int div(int x, int y)
        {
            return (x / y);
        }
    }
}
