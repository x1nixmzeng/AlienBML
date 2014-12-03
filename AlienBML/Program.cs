// Alien Isolation (Binary XML converter)
// Written by WRS (xentax.com)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlienBML
{
    class Program
    {
        static void Main(string[] args)
        {
            new AlienConverter(args).Run();
        }
    }
}
