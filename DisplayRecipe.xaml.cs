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
    /// Interaction logic for DisplayRecipe.xaml
    /// </summary>
    public partial class DisplayRecipe : Window
    {
        static RecipeFunctions objFunction = new RecipeFunctions();
        private List<RecipeManager> originalRecipeList = new List<RecipeManager>();
        public DisplayRecipe()
        {
            InitializeComponent();

            // Copy the original values to the originalRecipeList
            originalRecipeList.AddRange(AddDetails.lstProduct);
        }
        private void btnHalf_Click(object sender, RoutedEventArgs e)
        {
            objFunction.ScaleValues(0.5);
            lbxDisplayRecipe.Items.Clear();
            lbxDisplayRecipe.Items.Add("All Values Were Scaled By 0.5");


        }
        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
            objFunction.ScaleValues(2);
            lbxDisplayRecipe.Items.Clear();
            lbxDisplayRecipe.Items.Add("All Values Were Scaled By 2");

        }
        private void btnTriple_Click(object sender, RoutedEventArgs e)
        {
            objFunction.ScaleValues(3);
            lbxDisplayRecipe.Items.Clear();
            lbxDisplayRecipe.Items.Add("All Values Were Scaled By 3");

        }
        private void btnResetQ_Click(object sender, RoutedEventArgs e)
        {
            // Reset the recipe list to the original values
            AddDetails.lstProduct.Clear();
            AddDetails.lstProduct.AddRange(originalRecipeList);

            lbxDisplayRecipe.Items.Clear();
            lbxDisplayRecipe.Items.Add("All Values Were Reset To Original Values");
            searchName = txtsearch.Text;
            SearchRecipesByName(searchName);

        }
        public string searchName= "";
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchName = txtsearch.Text;
            SearchRecipesByName(searchName);

            txtsearch.Clear();
        }
        public void SearchRecipesByName(string Name)
        {
            List<RecipeManager> matchingRecipes = AddDetails.lstProduct.FindAll(recipe => recipe.recipeName.Equals(Name));

            if (matchingRecipes.Count > 0)
            {
                lbxDisplayRecipe.Items.Clear();
                lbxDisplayRecipe.Items.Add($"========Recipe Name======== \n {Name}");
                lbxDisplayRecipe.Items.Add("========Ingredients=========");
                foreach (RecipeManager recipe in matchingRecipes)
                {
                    lbxDisplayRecipe.Items.Add($" {recipe.ingreQyt} , {recipe.ingreMeasurement} of {recipe.ingreName} \n Calories: {recipe.calNum} \n Food Group: {recipe.foodGroup}");
                    foreach (string step in recipe.RecipeSteps)
                    {
                        lbxDisplayRecipe.Items.Add($"{step}");
                    }

                    lbxDisplayRecipe.Items.Add("-------------------------------------------------------");
                }
                lbxDisplayRecipe.Items.Add($"Total Calories: {objFunction.CalculateTotalCalories()}");
            }
            else
            {
                lbxDisplayRecipe.Items.Add($"No recipes found with the name '{Name}'.");
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
