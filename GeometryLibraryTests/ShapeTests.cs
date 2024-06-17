using GeometryLibrary.Factory;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleArea_ReturnsCorrectArea()
        {
            // Arrange
            var circleFactory = new CircleFactory();
            var circle = circleFactory.CreateShape(5);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 25, area, 0.001, "Площадь круга не соответствует ожидаемой.");
        }

        [Test]
        public void TriangleArea_ReturnsCorrectArea()
        {
            // Arrange
            var triangleFactory = new TriangleFactory();
            var triangle = triangleFactory.CreateShape(3, 4, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area, 0.001, "Площадь треугольника не соответствует ожидаемой.");
        }
    }
}
