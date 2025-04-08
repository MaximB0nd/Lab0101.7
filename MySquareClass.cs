using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF_Geometric.Models
{
    internal class MySquare : GeometricObject
    {
        private readonly int _size;

        public MySquare(int x, int y, Color color, int size) 
            : base(x, y, color)
        {
            _size = size;
        }

        public void Draw(Canvas canvas)
        {
            double rombSize = _size / Math.Sqrt(2); 
         
            var square = new Rectangle
            {
                Width = _size,
                Height = _size,
                Stroke = Brush,
                StrokeThickness = 2,
                Fill = Brushes.Transparent
            };
            Canvas.SetLeft(square, X - _size / 2);
            Canvas.SetTop(square, Y - _size / 2);
            canvas.Children.Add(square);

            
            var romb = new Rectangle
            {
                Width = rombSize,
                Height = rombSize,
                Stroke = Brush,
                StrokeThickness = 2,
                Fill = Brushes.Transparent,
                RenderTransform = new RotateTransform(45, rombSize / 2, rombSize / 2)
            };
            Canvas.SetLeft(romb, X - rombSize / 2);
            Canvas.SetTop(romb, Y - rombSize / 2);
            canvas.Children.Add(romb);

            
            var circle = new Ellipse
            {
                Width = rombSize,
                Height = rombSize,
                Stroke = Brush,
                StrokeThickness = 2,
                Fill = Brushes.Transparent
            };
            Canvas.SetLeft(circle, X - rombSize / 2);
            Canvas.SetTop(circle, Y - rombSize / 2);
            canvas.Children.Add(circle);
        }
    }
}