using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;
using sDB.Engine;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.CmdStruct
{
    class Document
    {
        public void CrtDoc(string tName)
        {
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            Console.WriteLine("Document Initialized; At: " + TValue);
            var crud = new CRUD();
            crud.CrReUpDe(tName);            
        }
    }
}
