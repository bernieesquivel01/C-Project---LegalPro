using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LegalPro_testcase
{
    class Program
    {

        static void Main(string[] args)
        {
            //XmlDocument Xdoc = new XmlDocument();
            //Xdoc.Load("/Users/bernie_esquivel/Desktop/testcase - sample (1).xml");
            //Xdoc.Save(Console.Out);

            XmlReaderSettings settings = new XmlReaderSettings
            {
                //IgnoreWhitespace = true,
                ValidationType = ValidationType.None
            };

            using (var fileStream = File.OpenText("/Users/bernie_esquivel/Desktop/testcase - sample (1).xml"))
            using (XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                while (reader.Read())
                {
                    bool cfg = reader.ReadToFollowing("field");
                    if (cfg == true)
                    {
                        string cfg_name = reader.GetAttribute("Name");
                        string cfg_value = reader.GetAttribute("Value");

                        Console.WriteLine(cfg_name + " " + cfg_value);

                    }
                }
            }



        }
    }
}