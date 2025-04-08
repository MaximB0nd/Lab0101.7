using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF_Geometric.Models
{
    internal class TriangleObject : GeometricObject
    {
        private readonly int _size;

        public TriangleObject(int x, int y, Color color, int size) 
            : base(x, y, color)
        {
            _size = size;
        }

        public void Draw(Canvas canvas)
        {
            var polygon = new Polygon
            {
                Fill = Brush,
                Points = new System.Windows.Media.PointCollection
                {
                    new System.Windows.Point(X, Y - _size / 2),
                    new System.Windows.Point(X - _size / 2, Y + _size / 2),
                    new System.Windows.Point(X + _size / 2, Y + _size / 2)
                }
            };
            canvas.Children.Add(polygon);
        }
    }
}