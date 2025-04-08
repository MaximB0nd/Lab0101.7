using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF_Geometric.Models
{
    internal class MyDrawingObject : GeometricObject
    {
        private readonly int _initialSize;
        private const double SCALE_FACTOR = 0.85;
        private const double ROTATION_STEP = 10;

        public MyDrawingObject(int x, int y, Color color, int size) 
            : base(x, y, color)
        {
            _initialSize = size;
        }

        public void Draw(Canvas canvas)
        {
            DrawRecursive(canvas, X, Y, _initialSize, 0);
        }

        private void DrawRecursive(Canvas canvas, double centerX, double centerY, double size, double rotationAngle)
        {
            if (size < 10) return;

            var square = new Rectangle
            {
                Width = size,
                Height = size,
                Stroke = Brush,
                StrokeThickness = 2,
                Fill = Brushes.Transparent,
                RenderTransform = new RotateTransform(rotationAngle, size/2, size/2)
            };

            Canvas.SetLeft(square, centerX - size / 2);
            Canvas.SetTop(square, centerY - size / 2);
            canvas.Children.Add(square);
            
            DrawRecursive(canvas, centerX, centerY, size * SCALE_FACTOR, rotationAngle + ROTATION_STEP);
        }
    }
}