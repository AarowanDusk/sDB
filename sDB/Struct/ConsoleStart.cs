using CSharpTest.Net.Collections;
using sDB.Engine;
using sDB.Err;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Struct
{
    class ConsoleStart
    {
        public void ConsoleSt(string docName)
        {
            var x = new main();
            var g = x.BTreeCreate(docName);
            var cnt = 0;
            using (var tree = new BPlusTree<string, String>(g))
            {
                foreach (var k in tree.Keys)
                {
                    cnt++;
                }
            }
            //Console.WriteLine(cnt);
            Console.Write("sDB>> " + docName + ">> ");
            var DPath = new DebugPath();
            DPath.DPath(docName, cnt);
            var CStart = new ConsoleStart();
            CStart.ConsoleSt(docName);
        }
    }
}
