using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Xmlserialisation
{
    class searialise
    {
        FileStream fs = null;
        public void savedata(personinfo pi)
        {
            try
            {
                fs = new FileStream(@"c:\Files\personinfo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(personinfo));
                xs.Serialize(fs, pi);
                Console.WriteLine("data serialized");

            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
        public personinfo getdata()
        {
            personinfo pi = null;
            try
            {
                fs = new FileStream(@"c:\Files\personinfo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(personinfo));
                pi = (personinfo)xs.Deserialize(fs);
              

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
            return pi;


        }
    }
}
