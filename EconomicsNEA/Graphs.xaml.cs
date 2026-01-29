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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Graphs: Window
    {
        public Graphs()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Supply_Demand_Click(object sender, RoutedEventArgs e)
        {
            string axisX = "Quantity";
            string axisY = "Price";
            var graphRender = new GraphRender(axisX,axisY);
            graphRender.Show();
        }
    }
}
