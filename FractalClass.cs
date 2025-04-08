using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF_Geometric.Models
{
    internal class Fractal : GeometricObject
    {
        private const double ANGLE = 25; 
        private const double SCALE = 0.75; 

        public Fractal(Color color) : base(0, 0, color) { }

        public void Draw(Canvas canvas, double x1, double y1, double x2, double y2, int depth)
        {
            if (depth == 0) return;

            DrawLine(canvas, x1, y1, x2, y2);
            
            double dx = x2 - x1;
            double dy = y2 - y1;
            double length = Math.Sqrt(dx * dx + dy * dy);

            if (length < 3) return;
            
            var random = new Random();
            double randomAngle = random.NextDouble() * 10 - 5; 
            
            double angleLeft = Math.PI * (ANGLE + randomAngle) / 180;
            double newX2L = x2 + (Math.Cos(angleLeft) * dx - Math.Sin(angleLeft) * dy) * SCALE;
            double newY2L = y2 + (Math.Sin(angleLeft) * dx + Math.Cos(angleLeft) * dy) * SCALE;
            double angleRight = Math.PI * (-ANGLE + randomAngle) / 180;
            double newX2R = x2 + (Math.Cos(angleRight) * dx - Math.Sin(angleRight) * dy) * SCALE;
            double newY2R = y2 + (Math.Sin(angleRight) * dx + Math.Cos(angleRight) * dy) * SCALE;

            Draw(canvas, x2, y2, newX2L, newY2L, depth - 1);
            Draw(canvas, x2, y2, newX2R, newY2R, depth - 1);
        }

        private void DrawLine(Canvas canvas, double x1, double y1, double x2, double y2)
        {
            Line line = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = Brush,
                StrokeThickness = 2 - 10 * 0.1f
            };
            canvas.Children.Add(line);
        }
    }
}