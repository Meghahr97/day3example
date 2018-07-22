using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Xmlincsharp
{
    class reafwritexml
    {
        List<bookInfo> blist = new List<bookInfo>();
        public reafwritexml()
        {
            blist.Add(new bookInfo { BookId = 1, Title = "malgudi days", Category = "story", Price = 350 });
            blist.Add(new bookInfo { BookId = 2, Title = "c programming", Category = "technlogy", Price = 550 });
            blist.Add(new bookInfo { BookId = 3, Title = "harry potter", Category = "fiction", Price = 700 });
        }
        public void writeXml()
        {
            XmlWriter w = XmlWriter.Create("c:\\files\\bookinfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("Bookinfo");
            foreach(var b in blist)
            {
                w.WriteStartElement("books");
                w.WriteAttributeString("BookId", b.BookId.ToString());
                w.WriteStartElement("description");
                w.WriteElementString("title", b.Title);
                w.WriteElementString("category", b.Category);
                w.WriteEndElement();//description
                w.WriteElementString("price", b.Price.ToString());
                w.WriteEndElement();// books
            }
            w.WriteEndElement();//bookinfo
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("xml created");
        }
        public void readxml()
        {
            XElement xe = XElement.Load("c:\\Files\\bookInfo.xml");
            var data = xe.Elements();
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("**********");
            //
           
            foreach(var d in data)
                Console.WriteLine(d.Element("description").Element("title").Value +" " +d.Element("price").Value);
            Console.WriteLine("*****");

            var data2 = from t in xe.Elements("Books")
                        where (int)t.Element("price") > 500
                        select t;
            foreach (var d in data2)
                Console.WriteLine(d);
        }
    }
}
