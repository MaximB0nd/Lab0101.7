using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WPF_Geometric.Models
{
    internal class PointObject : GeometricObject
    {
        public PointObject(int x, int y, Color color) 
            : base(x, y, color)
        {
        }

        public void Draw(Canvas canvas)
        {
            var ellipse = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = Brush
            };

            Canvas.SetLeft(ellipse, X - 5);
            Canvas.SetTop(ellipse, Y - 5);
            canvas.Children.Add(ellipse);
        }
    }
}