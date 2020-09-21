using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using sDB.Engine;
using sDB.Struct;


namespace sDB.Struct
{
    class LCustomer
    {
        List<DataType> list = new List<DataType>();
        public void ACustomer(int SLDepth, object SLValue, Type SLValueType, JsonToken SLTokenType, string SLPath)
        {
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            list.Add
                (
                new DataType
                {
                    LDepth = SLDepth,
                    LValue = SLValue,
                    LValueType = SLValueType,
                    LTokenType = SLTokenType,
                    LPath = SLPath
                }
                );
        }
        public void OCustomer(string docName, int cnt)
        {
            var bpTree = new Tree();
            var bpdata = new main();
            var tempData = bpdata.BTreeCreate(docName);
            int x = 0;
            foreach (var i in list)
            {                
                var xml = new XMLConvert();
                var tempValue = xml.CvXML(i.LDepth, i.LValue, i.LValueType, i.LTokenType, i.LPath, x + cnt);
                bpTree.AddDataTree(tempValue, tempValue + ".xml", tempData);
                x++;
            }
        }
        public void DCustomer()
        {
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            list.Clear();
            Console.WriteLine("Data Removed; At : " + TValue);
        }
    }
}


