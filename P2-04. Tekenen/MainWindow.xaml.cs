using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2_04.Tekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 250;
            myLine.Y1 = 1;
            myLine.Y2 = 150;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }

        private void btnDrawRectangle_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            rec.Fill = System.Windows.Media.Brushes.DarkCyan;
            rec.Stroke = System.Windows.Media.Brushes.LightGreen;
            rec.Height = 200;
            rec.Width = 300;
            rec.StrokeThickness = 5;
            mainGrid.Children.Add(rec);
        }

        private void btnDrawCircle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = 300;
            ellipse.Width = 100;
            ellipse.Fill = Brushes.DarkKhaki;
            ellipse.Stroke = Brushes.DarkOrange;
            ellipse.StrokeThickness = 5;
            //ellipse.Margin = new Thickness(100,100,0,0);
            mainGrid.Children.Add(ellipse);
        }

        private void btnDrawPolygon_Click(object sender, RoutedEventArgs e)
        {
            // Create a blue and a black Brush
            SolidColorBrush yellowBrush = new SolidColorBrush();
            yellowBrush.Color = Colors.Yellow;
            SolidColorBrush blackBrush = new SolidColorBrush();
            blackBrush.Color = Colors.Black;

            // Create a Polygon
            Polygon yellowPolygon = new Polygon();
            yellowPolygon.Stroke = blackBrush;
            yellowPolygon.Fill = yellowBrush;
            yellowPolygon.StrokeThickness = 4;

            // Create a collection of points for a polygon
            Point Point1 = new Point(50, 100);
            Point Point2 = new Point(200, 100);
            Point Point3 = new Point(200, 200);
            Point Point4 = new Point(300, 30);
            PointCollection polygonPoints = new PointCollection();
            polygonPoints.Add(Point1);
            polygonPoints.Add(Point2);
            polygonPoints.Add(Point3);
            polygonPoints.Add(Point4);

            // Set Polygon.Points properties
            yellowPolygon.Points = polygonPoints;

            // Add Polygon to the page
            mainGrid.Children.Add(yellowPolygon);
            //polygon.C
        }
    }
}
