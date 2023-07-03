using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ST10024680_Ernesto_VanWyk_PROG_POE
{
    class RecipeFunctions
    {
        //method to calculate and scale values 
        public void ScaleValues(double multiplier)
        {
            foreach (RecipeManager recipe in AddDetails.lstProduct)
            {
                recipe.ingreQyt *= multiplier;
            }
        }

        // Method to calculate total calories for a recipe
        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            bool caloriesExceeded = false;

            foreach (RecipeManager recipe in AddDetails.lstProduct)
            {
                totalCalories += recipe.calNum;

                if (totalCalories > 300)
                {
                    caloriesExceeded = true;
                }
            }

            // Check if total calories exceed 300 and raise the event
            if (caloriesExceeded)
            {
                //Show an error message to the user
                MessageBox.Show("Calories exceeded 300, Total: " + totalCalories,
                    "Null Entry",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            return totalCalories;
        }
        
    }
}
