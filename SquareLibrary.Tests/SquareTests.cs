using SquareLibrary.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Tests
{
    public class SquareTests
    {
        [Fact]
        public void CircleTest()
        {
            var radius = 2d;
            var circleConfig = new CircleConfigurations(radius);
            var expectedResult = Math.PI * Math.Pow(radius, 2);

            var result = Square.Count(circleConfig);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TriangleTest()
        {
            var sideA = 2d;
            var sideB = 3d;
            var sideC = 4d;
            var p = (sideA + sideB + sideC) / 2d;
            var expectedResult = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            var triangleConfig = new TriangleConfigurations(sideA, sideB, sideC);
            var result = Square.Count(triangleConfig);

            Assert.NotNull(triangleConfig);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void RightAngledTriangleTest()
        {
            var sideA = 3d;
            var sideB = 4d;
            var sideC = 5d;
            var expectedResult = (sideA * sideB) / 2d;

            var triangleConfig = new TriangleConfigurations(sideA, sideB, sideC);
            var result = Square.Count(triangleConfig);
            var triangleConfigWithDifferentSequence = new TriangleConfigurations(sideC, sideA, sideB);
            var resultWithDifferentSequence = Square.Count(triangleConfigWithDifferentSequence);

            Assert.NotNull(triangleConfig);
            Assert.NotNull(triangleConfigWithDifferentSequence);
            Assert.Equal(expectedResult, result);
            Assert.Equal(expectedResult, resultWithDifferentSequence);
        }
    }
}
