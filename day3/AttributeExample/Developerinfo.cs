using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Constructor|AttributeTargets.Property,AllowMultiple =true)]
    class Developerinfo:Attribute
    {
        public int EmpId { get; set; }
        public string name { get; set; }
        public string ProjName { get; set; }
        public string Dateofcreation { get; set; }
        public string Message { get; set; }
    }
}
