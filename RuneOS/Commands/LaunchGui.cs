﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;
using RuneOS.Graphics;

namespace RuneOS.Commands
{
    public class LaunchGui : Command
    {

        
        private PrisimGUI gui;

        public LaunchGui(String name) : base(name) { }

        public override string execute(string[] args)
        {
            if(Kernel.gui!=null)
            {
                return "GUI ACTIVE";
            }


            //gui = new GUI();
            gui = new PrisimGUI();
            
            return "";

        }

    }


}