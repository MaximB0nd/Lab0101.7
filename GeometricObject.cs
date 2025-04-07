using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Geometric.Models
{
    internal class GeometricObject
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected Brush Brush { get; set; }

        public GeometricObject(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Brush = new SolidColorBrush(color);
        }
    }
}