using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    class Program {
        static void Main(string[ ] args) {

            var c = new { R = SimpleUtils.IRandomRange(5, 50), H = SimpleUtils.IRandomRange(10, 100) };
            Cylinder cylinder = new Cylinder(c.R, c.H);
            Box box = new Box(
                SimpleUtils.IRandomRange(50, 100),
                SimpleUtils.IRandomRange(50, 100),
                SimpleUtils.IRandomRange(50, 100)
            );

            Console.WriteLine(Cylinder.GetInfo( ));
            Console.WriteLine(cylinder);
            Console.WriteLine(box);
            Console.WriteLine("Cylinder does " + (cylinder.IsPackedInBox(box) ? "" : "not ") + "pack in box");

        }
    }
}
