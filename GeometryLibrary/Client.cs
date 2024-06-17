using GeometryLibrary.Interfaces;

namespace GeometryLibrary
{
    public class Client
    {
        private readonly IShapeFactory _shapeFactory;

        public Client(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public void CalculateArea(params double[] parameters)
        {
            IShape shape = _shapeFactory.CreateShape(parameters);
            Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");
        }
    }
}
