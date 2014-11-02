using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //XPathDocument doc = new XPathDocument("http://www.public.asu.edu/~nkedia1/hotel_template.xml");
            //XslCompiledTransform xt = new XslCompiledTransform();
            //xt.Load("http://www.public.asu.edu/~nkedia1/hotel_template.xsl");
            //xt.Transform(doc, null, Response.OutputStream);

            //XmlTextReader reader = null;

            //reader = new XmlTextReader("http://www.public.asu.edu/~nkedia1/hotel_template.xml");
            //reader.WhitespaceHandling = WhitespaceHandling.None;
            //while (reader.Read())
            //{
            //    if (reader.NodeType == XmlNodeType.Element)
            //    {
            //        Console.WriteLine(reader.Name);
            //        if (reader.AttributeCount > 0)
            //        {
            //            while (reader.MoveToNextAttribute())
            //            {
            //                Console.WriteLine(reader.Name + ":" + reader.Value);
            //            }
            //        }
            //    }
            //    if (reader.NodeType == XmlNodeType.Text)
            //    {
            //        Console.WriteLine(reader.Value);
            //    }
            //}

            XmlDocument xref = new XmlDocument();
            xref.Load("http://www.public.asu.edu/~nkedia1/hotel_template.xml"); // or its URL
            preorderTraverse(xref.DocumentElement);
            Console.WriteLine("Done");
        }

        static void preorderTraverse(XmlNode node)
        { // recursive method
            Console.WriteLine("Type={0}\tName={1}\tValue={2}",
            node.NodeType, node.Name, node.Value);
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                    preorderTraverse(child); // recursive call
            }
        }


    }
}
