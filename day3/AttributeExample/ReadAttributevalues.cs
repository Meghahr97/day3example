using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    class ReadAttributevalues
    {
        public void ReadAttribute(Type t)
        {
            Developerinfo di=(Developerinfo)Attribute.GetCustomAttribute(t,typeof(Developerinfo));
            if (di == null)
                Console.WriteLine("No attribute used");
            else
            {
                Console.WriteLine(di.EmpId + " ," + di.name + "," + di.ProjName + "," + di.Dateofcreation + "," + di.Message);
            }
        }
    }
}
