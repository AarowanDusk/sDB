using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sDB.Struct
{
    class XMLRead
    {
        public void ReadXmlData( string hashName)
        { 
            using (XmlReader reader = XmlReader.Create(@"..\..\Storage\Data\"+hashName))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        var depth = reader["depth"];
                        var tokType = reader.Name.ToString();
                        var valType = reader["value_type"];
                        var path = reader["path"];
                        var directory = new XMLIDirectory();
                        directory.XMLDirectory
                            (
                            depth,
                            reader.ReadInnerXml().ToString(),
                            valType,
                            tokType,
                            path
                            );
                    }
                }
            }
        }
    }
}
