namespace TestTask
{
        public class Circle : Shape
        {
            public double Radius { get; set; }
            protected override double Perimeter { get => 2 * Math.PI * Radius; }
            public Circle(double radius)
            {
                if (radius <= 0)
                    throw new ArgumentOutOfRangeException($"Incorrect radisu");

                this.Radius = radius;
            }

            public override double Area
            {
                get => Math.PI * Math.Pow(Radius, 2);
            }
        }

}