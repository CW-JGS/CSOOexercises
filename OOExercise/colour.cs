using System;

namespace OOTest
{
    class Colour
    {
        internal int RValue {get;set;}
        internal int GValue {get;set;}
        internal int BValue {get;set;}

        public Colour(int[] pColourValue) {
            if (pColourValue.Length == 3) {
                RValue = pColourValue[0];
                GValue = pColourValue[1];
                BValue = pColourValue[2];
            } else {
                throw new Exception("Incorrect number of elements in array");
            }
        }
        public override string ToString()
        {
            return String.Format(" R: {0}, G: {1}, B: {2}",RValue, GValue, BValue );
        }
    }
}