using GeometryLibrary.Interfaces;
using GeometryLibrary.Shape;

namespace GeometryLibrary.Factory
{
    public class TriangleFactory : IShapeFactory
    {
        public IShape CreateShape(params double[] parameters)
        {
            if (parameters.Length != 3)
                throw new ArgumentException("Triangle requires three parameters");

            return new Triangle(parameters[0], parameters[1], parameters[2]);
        }
    }
}
