using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP7
{
    static class Transfer
    {
        public static string Name = "";
        public static string Country = "";
        public static string Adress = "";
        public static string Phone = "";

        public static void clean()
        {
            Name = ""; Country = ""; Adress = ""; Phone = "";
        }
    }

    class SaveInf
    {
        public string name;
        public int number;
        public float size;
        public float weight;
        public string date;
        public string type;
        public int count;
        public string producer;

        public SaveInf() { }
        public SaveInf(string N, int Nr, float S, float W, string D, string T, int C, string P)
        {
            name = N;
            number = Nr;
            size = S;
            weight = W;
            date = D;
            type = T;
            count = C;
            producer = P;
        }

        public override string ToString() => $"Name: {name} | Serial Number: {number} | Size: {size} | Weight: {weight} ";

        public void Load()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SaverI.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                name = node.Attributes[0].Value;
                number = int.Parse(node["number"].InnerText);
                size = float.Parse(node["size"].InnerText);
                weight = float.Parse(node["weight"].InnerText);
                date = node["date"].InnerText;
                type = node["type"].InnerText;
                count = int.Parse(node["count"].InnerText);
                producer = node["producer"].InnerText;
            }
        }

        public void Save()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SaverI.xml");


            foreach (XmlNode node in doc.DocumentElement)
            {
                node.Attributes[0].Value = name;
                node["number"].InnerText = number.ToString();
                node["size"].InnerText = size.ToString();
                node["weight"].InnerText = weight.ToString();
                node["date"].InnerText = date;
                node["type"].InnerText = type;
                node["count"].InnerText = count.ToString();
                node["producer"].InnerText = producer;
            }
                doc.Save("SaverI.xml");

        }
    }
}
