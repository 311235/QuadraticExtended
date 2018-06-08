//Kyler Campbell
//June 2, 2018
//Quadratic Extended
//Create program that finds anser to qudrqatic equation and plots zeros on graph


using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace u5Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        double a;
        double b;
        double c;
        double zero1;
        double zero2;



        //Making the graphics for the plotted zeros
        Ellipse TheFirstzero = new Ellipse();
        Ellipse TheSecondZero = new Ellipse();

        public MainWindow()
        {
            InitializeComponent();

            //Dimentions for zeros dot shape
            TheFirstzero.Height = 10;
            TheFirstzero.Width = 10;
            TheFirstzero.Fill = Brushes.Green;



            TheSecondZero.Height = 10;
            TheSecondZero.Width = 10;
            TheSecondZero.Fill = Brushes.Green;
        }

        public void Click_Calc(object Sender, RoutedEventArgs e)
        {

            canvas_Graph.Children.Remove(TheFirstzero);
            canvas_Graph.Children.Remove(TheSecondZero);
            canvas_Graph.Visibility = Visibility.Hidden;


            btn_Graph.Visibility = Visibility.Visible;


            double.TryParse(inpt_ValueA.Text, out a);
            double.TryParse(inpt_ValueB.Text, out b);
            double.TryParse(inpt_ValueC.Text, out c);

            zero1 = (-b - Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);
            zero2 = (-b + Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);

            txt_Output.Text = "Zero 1: " + zero1.ToString() + ". Zero 2: " + zero2.ToString();


        }

        public void Graph(object Sender, RoutedEventArgs e)
        {
            canvas_Graph.Visibility = Visibility.Visible;
            DrawZeros();
        }

        //Place zeros on graph
        public void DrawZeros()
        {
            canvas_Graph.Visibility = Visibility.Visible;
            canvas_Graph.Children.Remove(TheFirstzero);
            canvas_Graph.Children.Remove(TheSecondZero);
            canvas_Graph.Children.Add(TheFirstzero);
            canvas_Graph.Children.Add(TheSecondZero);


            Canvas.SetTop(TheFirstzero, 130);
            Canvas.SetTop(TheSecondZero, 130);

            //Different scenarios for zero placement
            if (zero1 == 9)
            {
                Canvas.SetLeft(TheFirstzero, 350);
            }


            else if (zero1 == 8)
            {
                Canvas.SetLeft(TheFirstzero, 330);
            }


            else if (zero1 == 7)
            {
                Canvas.SetLeft(TheFirstzero, 310);
            }


            else if (zero1 == 6)
            {
                Canvas.SetLeft(TheFirstzero, 290);
            }


            else if (zero1 == 5)
            {
                Canvas.SetLeft(TheFirstzero, 270);
            }


            else if (zero1 == 4)
            {
                Canvas.SetLeft(TheFirstzero, 250);
            }


            else if (zero1 == 3)
            {
                Canvas.SetLeft(TheFirstzero, 230);
            }


            else if (zero1 == 2)
            {
                Canvas.SetLeft(TheFirstzero, 210);
            }


            else if (zero1 == 1)
            {
                Canvas.SetLeft(TheFirstzero, 190);
            }


            else if (zero1 == 0)
            {
                Canvas.SetLeft(TheFirstzero, 175);
            }


            else if (zero1 == -1)
            {
                Canvas.SetLeft(TheFirstzero, 162);
            }


            else if (zero1 == -2)
            {
                Canvas.SetLeft(TheFirstzero, 142);
            }


            else if (zero1 == -3)
            {
                Canvas.SetLeft(TheFirstzero, 122);
            }


            else if (zero1 == -4)
            {
                Canvas.SetLeft(TheFirstzero, 102);
            }


            else if (zero1 == -5)
            {
                Canvas.SetLeft(TheFirstzero, 82);
            }


            else if (zero1 == -6)
            {
                Canvas.SetLeft(TheFirstzero, 62);
            }


            else if (zero1 == -7)
            {
                Canvas.SetLeft(TheFirstzero, 42);
            }


            else if (zero1 == -8)
            {
                Canvas.SetLeft(TheFirstzero, 22);
            }


            else if (zero1 == -9)
            {
                Canvas.SetLeft(TheFirstzero, 2);
            }


            else
            {
                MessageBox.Show("Not a number");
            }



            if (zero2 == 9)
            {
                Canvas.SetLeft(TheSecondZero, 350);
            }


            else if (zero2 == 8)
            {
                Canvas.SetLeft(TheSecondZero, 330);
            }


            else if (zero2 == 7)
            {
                Canvas.SetLeft(TheSecondZero, 310);
            }


            else if (zero2 == 6)
            {
                Canvas.SetLeft(TheSecondZero, 290);
            }


            else if (zero2 == 5)
            {
                Canvas.SetLeft(TheSecondZero, 270);
            }


            else if (zero2 == 4)
            {
                Canvas.SetLeft(TheSecondZero, 250);
            }


            else if (zero2 == 3)
            {
                Canvas.SetLeft(TheSecondZero, 230);
            }


            else if (zero2 == 2)
            {
                Canvas.SetLeft(TheSecondZero, 210);
            }


            else if (zero2 == 1)
            {
                Canvas.SetLeft(TheSecondZero, 190);
            }


            else if (zero2 == 0)
            {
                Canvas.SetLeft(TheSecondZero, 175);
            }


            else if (zero2 == -1)
            {
                Canvas.SetLeft(TheSecondZero, 165);
            }


            else if (zero2 == -2)
            {
                Canvas.SetLeft(TheSecondZero, 145);
            }


            else if (zero2 == -3)
            {
                Canvas.SetLeft(TheSecondZero, 125);
            }


            else if (zero2 == -4)
            {
                Canvas.SetLeft(TheSecondZero, 105);
            }


            else if (zero2 == -5)
            {
                Canvas.SetLeft(TheSecondZero, 85);
            }


            else if (zero2 == -6)

            {
                Canvas.SetLeft(TheSecondZero, 65);
            }


            else if (zero2 == -7)
            {
                Canvas.SetLeft(TheSecondZero, 45);
            }


            else if (zero2 == -8)
            {
                Canvas.SetLeft(TheSecondZero, 25);
            }


            else if (zero2 == -9)
            {
                Canvas.SetLeft(TheSecondZero, 5);
            }


            else
            {
                MessageBox.Show("Error");
            }
        }

       
    }
}
