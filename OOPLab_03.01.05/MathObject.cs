using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    static class MathObject {

        static public float GetCircleLength(float radius) { return 2f * (float)Math.PI * radius; }
        static public float GetArea(Cylinder cylinder) {
            return cylinder.Height * GetCircleLength(cylinder.Radius) + Cylinder.BASES_NUMBER * GetArea(cylinder.BaseCircle);
        }
        static public float GetArea(Circle circle) { return (float)(Math.PI * Math.Pow(circle.Radius, 2d)); }
        static public float GetVolume(Cylinder cylinder) { return GetArea(cylinder.BaseCircle) * cylinder.Height; }
        static public Boolean IsPackedInBox(this Cylinder cylinder, Box box) {
            float cylinderDiameter = cylinder.Radius * 2;
            float[ ] boxLengthes = new float[ ] { box.A, box.B, box.C };
            float[ ] cylinderLengthes = new float[ ] { cylinderDiameter, cylinderDiameter, cylinder.Height };
            Array.Sort(boxLengthes);
            Array.Sort(cylinderLengthes);
            for (int i = 0; i < 3; i++) {
                if (boxLengthes[i] < cylinderLengthes[i]) { return false; }
            }
            return true;
        }
    }
}
