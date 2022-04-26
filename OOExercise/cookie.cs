using System;

namespace OOTest
{
    class Cookie 
    {
        public int Weight {get;set;}
        public string Shape {get;set;}
        public Colour cookieColour;

        public Cookie (int pWeight, string pShape, int[] pColourValue) {
            this.Weight = pWeight;
            this.Shape = pShape;
            cookieColour = new Colour(pColourValue);
        }
        public override string ToString()
        {
            return String.Format(" {0}, {1}, {2}", Weight, Shape, cookieColour.ToString());
        }
    }
}