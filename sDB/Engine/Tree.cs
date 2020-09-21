using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;
using System.Security.Cryptography;
using sDB.Struct;

namespace sDB.Engine
{
    class Tree
    { 
        public void AddDataTree(string key, string fName, BPlusTree<string, String>.OptionsV2 treeData)
        {
            using (var tree = new BPlusTree<string, String>(treeData))
            {
                tree.Add(key, fName);
                tree.TryGetValue(key, out string cmpDate);
                var xmlNAME = new XMLRead();
                xmlNAME.ReadXmlData(cmpDate);
            }
        }
    }
}