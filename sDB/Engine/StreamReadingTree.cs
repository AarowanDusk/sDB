using com.sun.tools.javac.util;
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
    class StreamReadingTree
    {
        public void ReadDataTree(BPlusTree<string, String>.OptionsV2 treeData)
        {
            var iguifn = new StreamReadingReader();
            using (var tree = new BPlusTree<string, String>(treeData))
            {
                foreach(var k in tree.Keys)
                {
                    iguifn.readStreaming(tree.GetOrAdd(k, "00"));
                    //Console.WriteLine(tree.GetOrAdd(k, "00"));
                }
            }
            iguifn.oData();
        }
    }
}
