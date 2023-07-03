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

namespace ST10024680_Ernesto_VanWyk_PROG_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<string> ListRecipeName = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            captureName();
        }
        private void btnAddDescription_Click(object sender, RoutedEventArgs e)
        {
            //open the form for capturing the recipe details
            AddDetails objDetailsForm = new AddDetails();
            objDetailsForm.Show();
        }

        //method to capture the recipe names and save them into a list
        public void captureName()
        {

            //get the values entered in the txtbox and save into the variable
            string recipeName = txtRecipeName.Text;

            if (recipeName != "")
            {
                //Save the recipe name into the List
                ListRecipeName.Add(recipeName);
                txtRecipeName.Clear();
                //sort in order
                ListRecipeName.Sort();

            }
            else
            {
                //Show an error message to the user
                MessageBox.Show("Recipe Name Must Not Be Blank",
                    "Null Entry",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
