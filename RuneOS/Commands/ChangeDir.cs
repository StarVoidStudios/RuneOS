﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class ChangeDir : Command
    {

        public ChangeDir(String name) : base(name) { }

        public override string execute(string[] args)
        {

            //Console.WriteLine("File Name:");
            //var name = Console.ReadLine();
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {
                var files = Directory.GetFiles(@"0:\" + args[0]);
                var Dir = Directory.GetDirectories(@"0:\"+ args[0]);
                
                foreach (var file1 in files)
                {
                    Console.WriteLine(args[0]);
                    Console.WriteLine("<FILE> " + file1);

                }
                foreach (var subDir in Dir)
                {
                    Console.WriteLine("<DIR> " + subDir);


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            return "";









        }
    }
}