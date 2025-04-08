using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_Geometric.Models;

namespace WPF_Geometric
{
    public partial class MainWindow : Window
    {
        private readonly Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private Color GetSelectedColor()
        {
            return cmbColor.SelectedIndex switch
            {
                0 => Colors.Red,
                1 => Colors.Blue,
                2 => Colors.Green,
                _ => Colors.Black
            };
        }

        private int GetRandom(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void DrawPoint_Click(object sender, RoutedEventArgs e)
        {
            var point = new PointObject(
                GetRandom(0, 1000),
                GetRandom(0, 700),
                GetSelectedColor()
            );
            point.Draw(canvas);
        }

        private void DrawSquare_Click(object sender, RoutedEventArgs e)
        {
            var square = new SquareObject(
                GetRandom(0, 1000),
                GetRandom(0, 700),
                GetSelectedColor(),
                GetRandom(50, 200)
            );
            square.Draw(canvas);
        }

        private void DrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            var triangle = new TriangleObject(
                GetRandom(0, 1000),
                GetRandom(0, 700),
                GetSelectedColor(),
                GetRandom(50, 200)
            );
            triangle.Draw(canvas);
        }

        private void DrawMyDrawing_Click(object sender, RoutedEventArgs e)
        {
            var myDrawing = new MyDrawingObject(
                GetRandom(0, 1000),
                GetRandom(0, 700),
                GetSelectedColor(),
                300 
            );
            myDrawing.Draw(canvas);
        }

        private void DrawFractal_Click(object sender, RoutedEventArgs e)
        {
           
            Color color = GetSelectedColor(); 
            
            var fractal = new Fractal(color); 
    
        
            double startX = GetRandom(0, 1000);
            double startY = GetRandom(0, 700);
            double endX = startX;
            double endY = startY - 150; 
            
            fractal.Draw(canvas, startX, startY, endX, endY, 10);
        }
        private void DrawMySquare_Click(object sender, RoutedEventArgs e)
        {
            var mySquare = new MySquare(
                GetRandom(0, 1000),
                GetRandom(0, 700),
                GetSelectedColor(),
                200 
            );
            mySquare.Draw(canvas);
        }

        private void ClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }
    }
}