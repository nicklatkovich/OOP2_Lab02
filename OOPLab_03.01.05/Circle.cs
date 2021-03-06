﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    class Circle {
        private float _radius;

        public Circle(float radius) { this.Radius = radius; }

        public float Radius {
            get { return _radius; }
            set {
                if (value > 0) {
                    _radius = value;
                } else { throw new NotPositiveValueException("radius"); }
            }
        }

        public override String ToString( ) {
            return "Circle (Radius=" + this.Radius + ")";
        }
    }
}
