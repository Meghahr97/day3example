using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryserializationExample
{
    [Serializable]
    class personinfo
    {
        string name;
        int age;
        public personinfo()
        {

        }
        public personinfo(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void showdata()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("age:" + age);
        }

    }
}
