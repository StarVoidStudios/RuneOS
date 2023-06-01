using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneOS.Commands
{
    public class Command
    {
        public readonly String name;

        public Command(String name) {this.name = name;}

        public virtual string execute(String[] args) { return ""; }
        
        
        
        
        
        
    }
}
