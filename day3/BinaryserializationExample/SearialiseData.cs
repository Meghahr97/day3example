using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinaryserializationExample
{
    class SearialiseData
    {
        FileStream file = null;
        public void SaveData(personinfo pi)
        {
            try
            {
                file = new FileStream("c:\\Files\\Personinfo.bin", FileMode.Create,FileAccess.Write);
                BinaryFormatter format = new BinaryFormatter();
                format.Serialize(file, pi);
                Console.WriteLine("data serializes");

            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
        }

        public personinfo Getdata()
        {
            personinfo ps = null;
            try
            {
                file = new FileStream("c:\\Files\\Personinfo.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter format = new BinaryFormatter();
                ps=(personinfo)format.Deserialize(file);
               

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
            }
            return ps;
        }

    }
}
