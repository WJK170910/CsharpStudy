using System;
using System.Collections.Generic;
using System.Xml;

namespace XML操作
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peorsonList = new List<Person>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Develop\C#\Coding\ConsoleApplication\DevelopmentProcess\XML操作\Persons.xml");
            var xmlNodeList = xmlDocument.ChildNodes[1].ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Person person = new Person();
                foreach (XmlNode node in xmlNode.ChildNodes)
                {
                    //Console.WriteLine(node.Name + " - " + node.InnerText);
                    if (node.Name == "name")
                    {
                        person.Name = node.InnerText;
                        person.CultureCode = node.Attributes.Count == 0 ? null : node.Attributes[0].Value;
                    }
                    else
                    {
                        person.Age = int.Parse(node.InnerText);
                    }
                }
                Console.WriteLine(person.Name + " - " + person.Age + " - " + person.CultureCode);
            }

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Person person = new Person();
                XmlElement xmlElement = xmlNode["name"];
                person.Name = xmlElement.InnerText;
                xmlElement = xmlNode["age"];
                person.Age = int.Parse(xmlElement.InnerText);
                var xmlAttribute = xmlNode["name"].Attributes.Count == 0 ? null : xmlNode["name"].Attributes[0];
                person.CultureCode = xmlAttribute?.Value;
                Console.WriteLine("Name：" + person.Name + "," + "Age：" + person.Age + "," + "CultureCode：" + person.CultureCode);
            }

            Console.Read();
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string CultureCode { get; set; }
    }
}
