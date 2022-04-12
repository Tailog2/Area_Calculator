using System;
using Area_Calculator;
using Xunit;

namespace Area_Calculator_Test
{    

    public class UnitTest1
    {
        IShape rightTriangle = new Triangle(4, 6);
        IShape randomTriangle = new Triangle(4, 5, 3);
        IShape square = new Square(5);
        IShape invalidSquare = new Square(-5);
        IShape circle = new Circle(6);

        double expectedRightTriangle = 12;
        double expectedRandomTriangle = 6;
        double expectedSquare = 25;
        double expectedCircle = Math.PI * 6 * 6;

        [Fact]
        public void CalculateArea_rightTriangle_ShouldReturn12()
        {
            AreaCalculator areaCalculator = new AreaCalculator(rightTriangle);
            double area = areaCalculator.CalculateArea();
            Assert.Equal(expectedRightTriangle, area);
        }

        [Fact]
        public void CalculateArea_randomTriangle_ShouldReturn6()
        {
            AreaCalculator areaCalculator = new AreaCalculator(randomTriangle);
            double area = areaCalculator.CalculateArea();
            Assert.Equal(expectedRandomTriangle, area);
        }

        [Fact]
        public void CalculateArea_circle_ShouldReturn6()
        {
            AreaCalculator areaCalculator = new AreaCalculator(circle);
            double area = areaCalculator.CalculateArea();
            Assert.Equal(expectedCircle, area);
        }

        [Fact]
        public void CalculateArea_square_CalculateArea_circle_ShouldReturn25()
        {
            AreaCalculator areaCalculator = new AreaCalculator(square);
            double area = areaCalculator.CalculateArea();
            Assert.Equal(expectedSquare, area);
        }

        [Fact]
        public void CalculateArea_invalidSquare_ThrowException()
        {
            AreaCalculator areaCalculator = new AreaCalculator(invalidSquare);
            Assert.Throws<Exception>(() => areaCalculator.CalculateArea());
        }
    }
}
