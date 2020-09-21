using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sDB.CmdStruct;
using sDB.Engine;
using sDB.Err;
using sDB.Ini;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace sDB
{
    class Program
    {
        static void Main(string[] args)
        {

            //var x = new StreamReadingTree();
            //var g = x.BTreeRead();
            //x.ReadDataTree(g);
            //Console.Read();

            ////Console.WriteLine("Log in (y) || Create new account (c)");
            ////var dat = Console.ReadKey();
            ////switch (dat)
            ////{
            ////    case 'y':
            ////        {
            ////            break;
            ////        }
            ////    case "c":
            ////        {
            ////            break;
            ////        }
            ////    default:
            ////        {
            ////            break;
            ////        }
            ////}
            ////var x = new DBMaster();
            ////x.LogUser(true);
            //// dated



            Console.Write("sDB>> ");
            var docName = Console.ReadLine();
            var TValData = docName; 
            var CStart = new Document();
            CStart.CrtDoc(TValData);
            Console.Read();
        }       
    }
}
