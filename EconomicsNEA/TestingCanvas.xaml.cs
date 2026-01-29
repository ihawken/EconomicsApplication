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
using System.Windows.Shapes;

namespace EconomicsNEA
{
    /// <summary>
    /// Interaction logic for TestingCanvas.xaml
    /// </summary>
    public partial class TestingCanvas : Window
    {
        public TestingCanvas()
        {
            InitializeComponent();
            DrawAxis();

        }
        public void DrawAxis()
        {
            /*
             * <Line 
          X1="150" Y1="80"
          X2="150" Y2="490"
          Stroke="Black"
          StrokeThickness="2"
            />
            */
            var XaxisLabel = new Label();
            XaxisLabel.Content = "Quantity";
            

            var YaxisLabel = new Label();
            YaxisLabel.Content = "Price";
            var axisY = new Line();
            axisY.X1 = 150;
            axisY.Y1 = 80;
            axisY.X2 = 150;
            axisY.Y2 = 490;
            axisY.StrokeThickness = 3;
            axisY.Stroke = Brushes.Black;
            GraphCanvas.Children.Add(axisY);
            var axisX = new Line();
            axisX.X1 = 150;
            axisX.X2 = 560;
            axisX.Y1 = 490;
            axisX.Y2 = 490;
            axisX.StrokeThickness = 3;
            axisX.Stroke = Brushes.Black;
           


            GraphCanvas.Children.Add(axisX);





        }
    }

}
