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

namespace ST10024680_Ernesto_VanWyk_PROG_POE
{
    /// <summary>
    /// Interaction logic for MenuForm.xaml
    /// </summary>
    public partial class MenuForm : Window
    {
        RecipeFunctions objFunction = new RecipeFunctions();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            //open the form for displaying the recipe 
            DisplayRecipe objDisplayForm = new DisplayRecipe();
            objDisplayForm.Show();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbxMessage.Items.Clear();
            AddDetails.lstProduct.Clear();
            lbxMessage.Items.Add("All Elements Cleared");
        }
        private void btnchart_Click(object sender, RoutedEventArgs e)
        {
            //open the form for displaying the pieChart 
            PieChart objChartForm = new PieChart();
            objChartForm.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            lbxMessage.Items.Add("Good Bye");
            Close();
        }
    }
}
