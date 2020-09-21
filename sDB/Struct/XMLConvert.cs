using CSharpTest.Net.Collections;
using sDB.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sDB.Struct
{
    class XMLConvert
    {
        public string CvXML(Object depth, Object value, Object VType, Object TType, Object path, int x)
        {
            string DataString = null;
            DataString += "<" + TType + " path='"+ path +"' value_type='"+ VType + "' depth='" + depth + "' position='" + x + "'>";
            DataString += value;
            DataString += "</" + TType + ">";
            return XMLOut(DataString);           
        }
        public string XMLOut(string XMLInfo)
        {
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            var hash = new HashSys();
            var SetFName = hash.MD5Hash(TValue);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLInfo);
            XmlTextWriter writer = new XmlTextWriter(@"..\..\Storage\Data\" + SetFName + ".xml", null)
            {
                Formatting = Formatting.Indented
            };
            doc.Save(writer);
            writer.Flush();
            writer.Close();
            return SetFName;
        }
    }
}
