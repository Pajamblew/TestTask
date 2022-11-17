using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Triangle : Shape
    {
        public double firstSide { get; set; }
        public double secondSide { get; set; }
        public double thirdSide { get; set; }
        protected override double Perimeter { get => firstSide + secondSide + thirdSide; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 ||
                secondSide <= 0 ||
                thirdSide <= 0 ||
                firstSide >= secondSide + thirdSide ||
                secondSide >= firstSide + thirdSide ||
                thirdSide >= firstSide + secondSide)
            {
                throw new ArgumentOutOfRangeException($"Incorrect triangle side");
            }

            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override double Area => Math.Sqrt(Perimeter / 2
            * (Perimeter / 2 - firstSide)
            * (Perimeter / 2 - secondSide)
            * (Perimeter / 2 - thirdSide));

        public bool CheckForRight()
        {
            double[] sides = { firstSide, secondSide, thirdSide };
            sides.OrderBy(x => x);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
