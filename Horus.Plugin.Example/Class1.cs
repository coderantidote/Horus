using Plugin;
using System;

namespace PluginLibrary
{
    public class ReverseTest : IPluginInterface
    {
        public string Name =>  "Example ";
        public string Ver => "1.0";
        public string Action(string[] args)
        {
            Console.WriteLine(args[0]);
            return "Loaded Plugin" + Name + args[0];
        }

    }
}
