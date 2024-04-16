using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfAppTest2
{
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private Point startPoint;
        private string selectedShape = "Line";

        public MainWindow()
        {
            InitializeComponent();

            ListaDoMaloania.Items.Add("Line");
            ListaDoMaloania.Items.Add("Path");
            ListaDoMaloania.Items.Add("Polygon");
            ListaDoMaloania.Items.Add("Polyline");
            ListaDoMaloania.Items.Add("Rectangle");
            ListaDoMaloania.Items.Add("Shape");
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
            startPoint = e.GetPosition(CanvasTest);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = e.GetPosition(CanvasTest);

                switch (selectedShape)
                {
                    case "Line":
                        DrawLine(startPoint, currentPoint);
                        break;
                    case "Path":
                        DrawPath(startPoint, currentPoint);
                        break;
                    case "Polygon":
                        DrawPolygon(startPoint, currentPoint);
                        break;
                    case "Polyline":
                        DrawPolyline(startPoint, currentPoint);
                        break;
                    case "Rectangle":
                        DrawRectangle(startPoint, currentPoint);
                        break;
                    case "Shape":
                        DrawCustomShape(startPoint, currentPoint);
                        break;
                }

                startPoint = currentPoint;
            }
        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void ListaDoMaloania_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedShape = ListaDoMaloania.SelectedItem.ToString();
        }

        private void DrawLine(Point start, Point end)
        {
            Line line = new Line
            {
                Stroke = Brushes.Black,
                X1 = start.X,
                Y1 = start.Y,
                X2 = end.X,
                Y2 = end.Y
            };
            CanvasTest.Children.Add(line);
        }

        private void DrawPath(Point start, Point end)
        {
            Path path = new Path();
            path.Stroke = Brushes.Black;
            PathGeometry pathGeometry = new PathGeometry();
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = start;
            LineSegment lineSegment = new LineSegment(end, true);
            pathFigure.Segments.Add(lineSegment);
            pathGeometry.Figures.Add(pathFigure);
            path.Data = pathGeometry;
            CanvasTest.Children.Add(path);
        }

        private void DrawPolygon(Point start, Point end)
        {
            Polygon polygon = new Polygon();
            polygon.Stroke = Brushes.Black;
            polygon.Fill = Brushes.Transparent;
            PointCollection points = new PointCollection();
            points.Add(start);
            points.Add(new Point(start.X, end.Y));
            points.Add(end);
            polygon.Points = points;
            CanvasTest.Children.Add(polygon);
        }

        private void DrawPolyline(Point start, Point end)
        {
            Polyline polyline = new Polyline();
            polyline.Stroke = Brushes.Black;
            PointCollection points = new PointCollection();
            points.Add(start);
            points.Add(end);
            polyline.Points = points;
            CanvasTest.Children.Add(polyline);
        }

        private void DrawRectangle(Point start, Point end)
        {
            double width = Math.Abs(end.X - start.X);
            double height = Math.Abs(end.Y - start.Y);

            Rectangle rectangle = new Rectangle
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Transparent,
                Width = width,
                Height = height
            };

            Canvas.SetLeft(rectangle, Math.Min(start.X, end.X));
            Canvas.SetTop(rectangle, Math.Min(start.Y, end.Y));

            CanvasTest.Children.Add(rectangle);
        }

        private void DrawCustomShape(Point start, Point end)
        {
            Ellipse ellipse = new Ellipse
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Transparent,
                Width = Math.Abs(end.X - start.X),
                Height = Math.Abs(end.Y - start.Y)
            };

            Canvas.SetLeft(ellipse, Math.Min(start.X, end.X));
            Canvas.SetTop(ellipse, Math.Min(start.Y, end.Y));

            CanvasTest.Children.Add(ellipse);
        }
    }
}
