using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WPF_Geometric.Models
{
    internal class MySquareObject : GeometricObject
    {
        private readonly int _size;

        public MySquareObject(int x, int y, string colorName, Color color, int size) 
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
                Stroke = Brush,
                StrokeThickness = 4
            };

            Canvas.SetLeft(rect, X - _size / 2);
            Canvas.SetTop(rect, Y - _size / 2);
            canvas.Children.Add(rect);
        }
    }
}