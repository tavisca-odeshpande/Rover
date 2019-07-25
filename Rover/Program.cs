using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Mars map = new Mars();
            Rov r = new Rov("1", "2", Directions.North,map);
            r.DisplayVectorPosition();

            Console.WriteLine("F");
            r.PassInstruction("F");
            r.DisplayVectorPosition();

            Console.WriteLine("L");
            r.PassInstruction("L");
            r.DisplayVectorPosition();

            Console.WriteLine("F");
            r.PassInstruction("F");
            r.DisplayVectorPosition();

            Console.WriteLine("R");
            r.PassInstruction("R");
            r.DisplayVectorPosition();

            Console.WriteLine("F");
            r.PassInstruction("F");
            r.DisplayVectorPosition();

            Console.ReadKey();
           
        }
    }
}
