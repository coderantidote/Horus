using Plugin;
using System;

namespace PluginLibrary
{
    public class ReverseTest : IPluginInterface
    {
        public string Name
        {
            get { return "Example "; } // generate new plugin 
        }
        public string Ver
        {
            get { return "1.0"; } // generate new plugin 
        }
        public string Action(string[] args)
        {
            Console.WriteLine(args[0]);
            return "Loaded Plugin" + Name + args[0];
        }

    }
}
