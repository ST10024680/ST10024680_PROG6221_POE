using LiveCharts;
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
    /// Interaction logic for AddDetails.xaml
    /// </summary>
    public partial class AddDetails : Window
    {
        internal static List<RecipeManager> lstProduct = new List<RecipeManager>();


        public AddDetails()
        {
            InitializeComponent();
            foreach (string name in MainWindow.ListRecipeName)
            {
                cmbRecipeName.Items.Add(name);

            }
            cmbRecipeName.SelectedIndex = 0;


        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            //open the form for capturing the recipe details
            MenuForm objMenuForm = new MenuForm();
            objMenuForm.Show();
        }
        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            string rName = (string)cmbRecipeName.SelectedItem;
            double recipeQuantity = Convert.ToDouble(txtQuantity.Text);
            string ingrename = textingrename.Text;
            string recipeMeasurement = txtUnitOMeasure.Text;
            int calories = Convert.ToInt32(txtCalories.Text);
            string foodG = txtFoodGroup.Text;
            string[] recipeStepsArray = txtSteps.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> recipeStepsList = new List<string>(recipeStepsArray);

            lstProduct.Add(new RecipeManager(rName, recipeQuantity, ingrename, calories, foodG, recipeMeasurement, new List<string>(recipeStepsList)));


            displayCal.Items.Add("========Recipe Name======== \n" + rName);
            displayCal.Items.Add("========Ingredients=========");
            displayCal.Items.Add($" {recipeQuantity} , {recipeMeasurement} of {ingrename} \n Calories: {calories} \n Food Group: {foodG} \n Steps: {txtSteps.Text}'");
            displayCal.Items.Add("-------------------------------------------------------");
            txtQuantity.Clear();
            txtUnitOMeasure.Clear();
            txtCalories.Clear();
            txtFoodGroup.Clear();
            txtSteps.Clear();


        }
    }
}
