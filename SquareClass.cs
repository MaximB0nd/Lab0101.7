using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WPF_Geometric.Models
{
    internal class SquareObject : GeometricObject
    {
        private readonly int _size;

        public SquareObject(int x, int y, Color color, int size) 
            : base(x, y, color)
        {
            _size = size;
        }

        public void Draw(Canvas canvas)
        {
            var rect = new Rectangle
            {
                Width = _size,
                Height = _size,
                Fill = Brush
            };

            Canvas.SetLeft(rect, X - _size / 2);
            Canvas.SetTop(rect, Y - _size / 2);
            canvas.Children.Add(rect);
        }
    }
}