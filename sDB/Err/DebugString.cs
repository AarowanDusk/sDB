using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sDB.Engine;
using sDB.log;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Err
{
    class DebugString
    {
        public void DStr(string str, string docName, int cnt)
        {
            var logf = new SDBLog();
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            var addCustomer = new LCustomer();
            try
            {
                if (Path.IsPathRooted(str)) {
                    var customer_Get = new StreamReading();
                    customer_Get.ReadST(str, addCustomer, docName, cnt);
                }
                else if (str == "read")
                {
                    var x = new main();
                    var g = x.BTreeCreate(docName);
                    var y = new StreamReadingTree();
                    y.ReadDataTree(g);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown Command; At : " + TValue);
                    Console.ResetColor();
                }
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error 102: Phase Error; At : " + TValue);
                addCustomer.DCustomer();
                Console.ResetColor();
                logf.Log
                    (
                    "=========================" +
                    Environment.NewLine +
                    "Newtonsoft.Json.JsonReaderException" +
                    Environment.NewLine +
                    "Error 102: Phase Error;" +
                    Environment.NewLine +
                    "At : " +
                    TValue +
                    Environment.NewLine,
                    "102"
                    );
            }
        }
    }
}
