using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sDB.Struct
{
    class StreamReadingReader
    {
        private List<DataTypeXML> listVal = new List<DataTypeXML>();
        public void readStreaming(string link)
        {
            using (XmlReader reader = XmlReader.Create(@"..\..\Storage\Data\" + link))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        listVal.Add
                        (
                        new DataTypeXML
                        {
                            LDepth = int.Parse(reader["depth"]),
                            LValueType = reader["value_type"].ToString(),
                            LTokenType = reader.Name.ToString(),
                            LPath = reader["path"].ToString(),
                            LPosition = int.Parse(reader["position"]),
                            LValue = reader.ReadInnerXml().ToString(),
                        }
                        );
                    }
                }
            }
        }
        public void oData()
        {
            foreach(var i in listVal.OrderBy(x => x.LPosition))
            {
                if (i.LTokenType == "StartObject")
                {
                    Console.WriteLine("{");
                }
                if (i.LTokenType == "PropertyName")
                {
                    for (var z = 0; z <= i.LDepth; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\"" + i.LValue + "\" : ");
                }
                if (i.LTokenType == "StartArray")
                {
                    Console.WriteLine("[");
                }
                if (i.LTokenType != "StartObject" && i.LTokenType != "PropertyName" && i.LTokenType != "StartArray" && i.LTokenType != "EndArray" && i.LTokenType != "EndObject")
                {
                    Console.WriteLine("\"" + i.LValue + "\",");
                }
                if (i.LTokenType == "EndArray")
                {
                    for (var z = 0; z <= i.LDepth; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("]");
                }
                if (i.LTokenType == "EndObject")
                {
                    for (var z = 0; z <= i.LDepth; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("}");
                }
            }
        }
    }
}
