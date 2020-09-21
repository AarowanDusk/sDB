using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Struct
{
    class XMLIDirectory
    {
        public DataTypeXML AddVal(int SLDepth, string SLValue, string SLValueType, string SLTokenType, string SLPath)
        {
            var data = new DataTypeXML
            {
                LDepth = SLDepth,
                LValue = SLValue,
                LValueType = SLValueType,
                LTokenType = SLTokenType,
                LPath = SLPath
            };
            return data;
        }

        private List<DataTypeXML> PropertyName = new List<DataTypeXML>();
        private List<DataTypeXML> StartObject = new List<DataTypeXML>();
        private List<DataTypeXML> EndObject = new List<DataTypeXML>();
        private List<DataTypeXML> StartArray = new List<DataTypeXML>();
        private List<DataTypeXML> EndArray = new List<DataTypeXML>();
        private List<DataTypeXML> defaultVal = new List<DataTypeXML>();
        public void XMLDirectory(string SLDepth, string SLValue, string SLValueType, string SLTokenType, string SLPath)
        {
            switch (SLTokenType)
            {
                case "PropertyName":
                    {
                        PropertyName.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );
                        break;
                    }
                case "StartObject":
                    {
                        StartObject.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );
                        break;
                    }
                case "EndObject":
                    {
                        EndObject.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );
                        break;
                    }
                case "StartArray":
                    {
                        StartArray.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );
                        break;
                    }
                case "EndArray":
                    {
                        EndArray.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );
                        break;
                    }
                default:
                    {
                        defaultVal.Add
                           (
                            AddVal(int.Parse(SLDepth), SLValue, SLValueType, SLTokenType, SLPath)
                           );                        
                        break;                        
                    }
            }
            FirstMatch();
        }

        public void FirstMatch()
        {
            var newList = PropertyName.Concat(StartObject).Concat(StartArray).Concat(EndArray).Concat(EndObject).Concat(defaultVal);
            foreach(var x in newList)
            {
                foreach(var i in newList)
                {
                    if(x.LPath == i.LPath)
                    {
                        if(i.LTokenType == "StartObject")
                        {
                            Console.WriteLine("{");
                        }
                        if(i.LTokenType == "PropertyName")
                        {
                            for (var z = 0; z <= i.LDepth; z++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("\"" + x.LValue + "\" : ");
                        }
                        if(i.LTokenType == "StartArray")
                        { 
                            Console.WriteLine("[");
                        }
                        if(i.LTokenType != "StartObject" && i.LTokenType != "PropertyName" && i.LTokenType != "StartArray" && i.LTokenType != "EndArray" && i.LTokenType != "EndObject")
                        {
                            Console.WriteLine("\"" + i.LValue + "\",");
                        }
                        if(i.LTokenType == "EndArray")
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
    }
}


//!int.Parse(i.LDepth) && !defaultVal.Any()) == true