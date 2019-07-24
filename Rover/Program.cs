using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Rov r = new Rov("1", "2", Directions.North);
            r.DisplayVectorPosition();
            r.PassInstruction("F");
            r.DisplayVectorPosition();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
