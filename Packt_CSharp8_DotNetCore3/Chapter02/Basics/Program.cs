using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()) {
                // Load the assembly so we can read its details.
                var a  = Assembly.Load(new AssemblyName(r.FullName));
                // Declare a variable to count the number of methods.
                int methodCount = 0;
                // Loop through all the types in the assembly
                foreach(var t in a.DefinedTypes) {
                    // Add up the counts of methods.
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name);
            }
        }
    }
}
