using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    class NotPositiveValueException : Exception {

        public NotPositiveValueException(string valueName) :
            base("The " + valueName + " can not be negative or zero") { }

    }
}
