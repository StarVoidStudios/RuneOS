using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RuneOS.Utils;

namespace RuneOS.Commands
{
    public class callDebug : Command
    {
        public callDebug(String name) : base(name) { }

        public override string execute(string[] args)
        {
            try
            {
                if (args[0] == "-r")
                {


                    Debug.ErrorScreen("SELF_INIT: DEBUG");

                }
                else if (args[0]== "-f")
                {

                    Debug.FailedToBoot("SELF_INIT: DEBUG");

                }
                else
                {
                    Console.WriteLine("DEBUG OPTION NOT VAILD");
                }

            }
            catch(Exception)
            {
                Console.WriteLine("INVALID ARGS");
            }

            return "";

        }




    }

   
}










  