using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10024680_Ernesto_VanWyk_PROG_POE
{
    class RecipeManager
    {
        

        //properties
        public string recipeName { get; set; }
        public double ingreQyt { get; set; }
        public string ingreName { get; set; }
        public int calNum { get; set; }
        public string foodGroup { get; set; }
        public string ingreMeasurement { get; set; }
        public List<string> RecipeSteps { get; set; }


        public RecipeManager(string rName, double recipeQuantity, string ingrename, int calories, string foodG, string recipeMeasurement, List<string> recipeSteps)
        {
            recipeName = rName;
            ingreQyt = recipeQuantity;
            ingreName = ingrename;
            calNum = calories;
            foodGroup = foodG;
            ingreMeasurement = recipeMeasurement;
            RecipeSteps = recipeSteps;

        }
    }
}
