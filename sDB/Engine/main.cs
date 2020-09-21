using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Engine
{
    class main
    {
        public BPlusTree<string, String>.OptionsV2 BTreeCreate(string docName)
        {
            var hash = new HashSys();
            var SetFName = hash.MD5Hash(docName);
            var options = new BPlusTree<string, String>.OptionsV2(PrimitiveSerializer.String, PrimitiveSerializer.String)
            {
                CreateFile = CreatePolicy.IfNeeded,
                FileName = @"..\..\Storage\Tree\" + SetFName + ".tmp"
            };
            return options;
        }
    }
}
