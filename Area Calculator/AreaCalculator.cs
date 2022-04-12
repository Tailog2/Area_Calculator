using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    public class AreaCalculator
    {
        private readonly IShape _shape;

        public AreaCalculator(IShape shape)
        {
            _shape = shape;
        }

        public double CalculateArea()
        {
            return _shape.CalculateArea();
        }
    }
}
