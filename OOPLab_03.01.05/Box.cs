using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    class Box {
        private float _a;
        private float _b;
        private float _c;

        private const string ABC_VALUES_NAME = "length of the box edge";

        public Box(float a, float b, float c) {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public float A {
            get { return this._a; }
            set {
                if (value > 0) {
                    this._a = value;
                } else { throw new NotPositiveValueException(ABC_VALUES_NAME); }
            }
        }
        public float B {
            get { return this._b; }
            set {
                if (value > 0) {
                    this._b = value;
                } else { throw new NotPositiveValueException(ABC_VALUES_NAME); }
            }
        }
        public float C {
            get { return _c; }
            set {
                if (value > 0) {
                    this._c = value;
                } else { throw new NotPositiveValueException(ABC_VALUES_NAME); }
            }
        }

        public override String ToString( ) {
            string result = "Box {\n";
            result += "\tA : " + this.A + "\n";
            result += "\tB : " + this.B + "\n";
            result += "\tC : " + this.C + "\n";
            result += "}";
            return result;
        }

    }
}
