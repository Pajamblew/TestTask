using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        protected override double Perimeter { get => FirstSide + SecondSide + ThirdSide; }
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

            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public override double Area => Math.Sqrt(Perimeter / 2
            * (Perimeter / 2 - FirstSide)
            * (Perimeter / 2 - SecondSide)
            * (Perimeter / 2 - ThirdSide));

        public bool CheckForRight()
        {
            double[] sides = { FirstSide, SecondSide, ThirdSide };
            double[] sortedSides = sides.OrderBy(x => x).ToArray();


            return Math.Pow(sortedSides[2], 2) == Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2);
        }
    }
}
