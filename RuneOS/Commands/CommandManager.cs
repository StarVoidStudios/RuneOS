﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class CommandManager
    {
        private List<Command> commands;

        public CommandManager() 
        { 
        
            this.commands= new List<Command>();
            this.commands.Add(new Help("help"));
            this.commands.Add(new About("about"));
            this.commands.Add(new Power("pwr"));
            this.commands.Add(new directory("dir"));
            this.commands.Add(new Clear("cls"));
            this.commands.Add(new LaunchGui("startx"));
            this.commands.Add(new Write("write"));
            this.commands.Add(new Mkfile("mkfile"));
            this.commands.Add(new Delfile("rmfile"));
            this.commands.Add(new Read("cat"));
            this.commands.Add(new miv("miv"));
            this.commands.Add(new rmdir("rmdir"));
            this.commands.Add(new mkdir("mkdir"));
            this.commands.Add(new callDebug("debug"));
            this.commands.Add(new info("info"));
            this.commands.Add(new cd("cd"));
            this.commands.Add(new Graphics("startxtest"));
            
            
        
        }

        public String input (String input)
        {
            String[] split = input.Split(' ');

            String label = split[0];
            
            List<String> args = new List<String>();

            int ctr=0;

            foreach (String s in split) {
                if (ctr != 0)
                {
                    args.Add(s);
                }
                 ctr++;
            
            }

            foreach(Command cmd in this.commands)
            {
                if (cmd.name==label)
                   return cmd.execute(args.ToArray());
            }

            Console.ForegroundColor = ConsoleColor.Red;
            return "BAD COMMAND";


        }

    }
}
