using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_03._01._05 {
    static class SimpleUtils {

        static private Random rand = new Random( );
        public static Int32 IRandom(Int32 maxValue) { return rand.Next( ) % (maxValue + 1); }
        public static Int32 IRandomRange(Int32 minValue, Int32 maxValue) {
            return minValue + IRandom(maxValue - minValue);
        }
        static public float Min(float a, float b) {
            return (a < b ? a : b);
        }
        static public float Min(float a, float b, float c) {
            return Min(a, Min(b, c));
        }
        static public float Max(float a, float b) {
            return (a > b ? a : b);
        }
        static public float Max(float a, float b, float c) {
            return Max(a, Max(b, c));
        }
        static public float Median(float[ ] f) {
            float[ ] temp = (float[ ])f.Clone( );
            Array.Sort(temp);
            return temp[(temp.Length - 1) << 1];
        }
    }
}
