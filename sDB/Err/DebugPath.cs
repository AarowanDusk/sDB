using sDB.Ini;
using sDB.log;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Err
{
    class DebugPath
    {
        public void DPath(string DocName, int cnt)
        {
            var TStamp = new TimeStamp();
            var TValue = TStamp.TStamp();
            var logf = new SDBLog();
            try
            {
                var ini = new Init
                {
                    Str = Console.ReadLine()
                };
                ini.StrData(DocName, cnt);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error 101.1: Path not found; At : " + TValue);
                Console.ResetColor();
                logf.Log
                    (
                    "=========================" +
                    Environment.NewLine +
                    "System.IO.FileNotFoundException;" +
                    Environment.NewLine +
                    "Error 101.1: Path not found;" +
                    Environment.NewLine +
                    "At : " +
                    TValue +
                    Environment.NewLine,
                    "101.1"
                    );
            }
            catch (System.ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error 101.2: Empty path; At : " + TValue);
                Console.ResetColor();
                logf.Log
                    (
                    "=========================" +
                    Environment.NewLine +
                    "System.ArgumentException;" +
                    Environment.NewLine +
                    "Error 101.2: Empty path;" +
                    Environment.NewLine +
                    "At : " +
                    TValue +
                    Environment.NewLine,
                    "101.2"
                    );
            }
        }
    }
}
