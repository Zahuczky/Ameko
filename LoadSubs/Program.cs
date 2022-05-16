using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ameko.AssCS;

namespace LoadSubs
{
    class Program
    {
        static void Main(string[] args)
        {

            var h = Ameko.AssCS.AssParser.LoadAndParse("C:\\__SUBS\\base_kfx.ass");
            
            Console.WriteLine("It works\n");
            
            foreach(KeyValuePair<string, string> kvp in h.ScriptMetadata)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            
            Console.WriteLine("\nProject garbage should be above\n");
            
            Console.WriteLine(h.ScriptExtradata[1]);
            
            Console.WriteLine("\nExtradata should be above\n");

            Console.ReadLine();
        }
		
    }
}