using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EconomicsNEA
{
    /// <summary>
    /// Interaction logic for GraphRender.xaml
    /// </summary>
    public partial class GraphRender : Window
    {
        
        private string AxisY = "";
        private string AxisX = "";

        public GraphRender(string axisX,string axisY)
        {
            AxisX = axisX;
            AxisY = axisY;
            InitializeComponent();
            if (axisX == "Quantity" && axisY == "Price")
            {
                DrawSupplyAndDemand();
            }
            DrawAxis(axisX, axisY);

        }

        public  void DrawGraph()
        {
            
        }
        public void DrawAxis(string axis1,string axis2)
        {
            XaxisName.Content = axis1;
            YaxisName.Content = axis2;
        }
        public void DrawSupplyAndDemand()
        {


            var Supply = new Line();
            Supply.Stroke = System.Windows.Media.Brushes.Red;
            Supply.X1 = -10;
            Supply.X2 = 500;
            Supply.Y1 = 250;
            Supply.Y2 = 0;
            
            Supply.VerticalAlignment = VerticalAlignment.Center;
            Supply.HorizontalAlignment = HorizontalAlignment.Left;
        
            Supply.StrokeThickness = 3;
            var supplyLabel = new Label();
            double midX = (Supply.X1 + Supply.X2) / 2;
            double midY = (Supply.Y1 + Supply.Y2) / 2;
            

            

            supplyLabel.Content = "S";
            supplyLabel.FontSize = 20;
            var x = midX + 148;
            MessageBox.Show(Convert.ToString(x));
            supplyLabel.Margin = new Thickness(midX+148, 40, 0, 0);
            
            RestraintForLines.Children.Add(Supply);
            RestraintForLines.Children.Add(supplyLabel);
            var Demand = new Line();
            Demand.Stroke = System.Windows.Media.Brushes.Blue;
            Demand.X1 = -10;
            Demand.X2 = 500;
            Demand.Y1 = 10;
            Demand.Y2 = 325;
         
            Demand.VerticalAlignment = VerticalAlignment.Center;
            Demand.HorizontalAlignment = HorizontalAlignment.Left;
            Demand.StrokeThickness = 3;
            var DemandLabel = new Label();
            DemandLabel.Content = "D";
            DemandLabel.FontSize = 20;
            DemandLabel.Margin = new Thickness(midX + 145, 227, 0, 0);
            RestraintForLines.Children.Add(DemandLabel);
            RestraintForLines.Children.Add(Demand);
            





        }
    }




}
