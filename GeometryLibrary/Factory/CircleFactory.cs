using GeometryLibrary.Interfaces;
using GeometryLibrary.Shape;

namespace GeometryLibrary.Factory
{
    public class CircleFactory : IShapeFactory
    {
        public IShape CreateShape(params double[] parameters)
        {
            if (parameters.Length != 1)
                throw new ArgumentException("Circle requires one parameter");

            return new Circle(parameters[0]);
        }
    }
}
