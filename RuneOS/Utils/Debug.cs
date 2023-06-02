using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace RuneOS.Utils
{
    public class Debug
    {

        public bool bootflag;
        

        public static void ErrorScreen(string err_txt)
        {
           
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("RUNE OS has encounterd a fatal error and cannot recover");
                Console.WriteLine();
                Console.WriteLine("VERSION INFO: 0.3.0  BUILD:06012023 ");
                Console.WriteLine("For more infomation about this issue and possiable fixes, visit: <https://github.com/Starvoidstudios/RuneOS> ");
                Console.WriteLine("When Creating a ticket please give this info and the Version and Build Number: ");
                Console.WriteLine("Error Code: " + err_txt);
                Console.WriteLine("Collecting info: " + i + "%");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
               
            }
            Console.WriteLine("Please press Enter key to reboot");
            Console.ReadLine();
            Sys.Power.Reboot();
            
           


        }
        public static void FailedToBoot(string err_txt)
        {
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("RUNE OS has failed to boot");
                Console.WriteLine();
                Console.WriteLine("VERSION INFO: 0.3.0  BUILD:06012023 ");
                Console.WriteLine("Please Remember to use the PWR command to properly shutdown RuneOS to avoid corruption or data loss");
                Console.WriteLine("If your seeing this screen as a result of a computer crash please follow the info below");
                Console.WriteLine("When Creating a ticket please give this info and the Version and Build Number: ");
                Console.WriteLine("Error Code: " + err_txt);
                Console.WriteLine("Collecting info: " + i + "%");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Press Any key to reboot RuneOS");
            Console.ReadLine();
            Sys.Power.Reboot();
            
            






        }

       

        
        
        





    }
}
