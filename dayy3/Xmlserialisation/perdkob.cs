using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xmlserialisation
{
    [Serializable]
    [XmlRoot]
   public class personinfo
    {
        [XmlElement]

        public string Name { get; set; }
        [XmlElement]
        public int age { get; set; }
        public personinfo()
        {

        }
        public personinfo(string n,int a)
        {
            Name = n;
            age = a;
        }
        public void showdata()
        {
            Console.WriteLine("name:" + Name);
            Console.WriteLine("age:" + age);
        }
    }
}
