using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Definitions.Charts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
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
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : Window
    {
        public SeriesCollection FoodGroupSeries { get; set; }
        public PieChart()
        {
            InitializeComponent();
            FoodGroupSeries = new SeriesCollection();

            // Call the UpdateFoodGroupChart method to initially populate the pie chart
            UpdateFoodGroupChart();


        }
        private void UpdateFoodGroupChart()
        {
            // Count the occurrence of each food group
            Dictionary<string, int> foodGroupCounts = new Dictionary<string, int>();
            foreach (RecipeManager recipe in AddDetails.lstProduct)
            {
                if (foodGroupCounts.ContainsKey(recipe.foodGroup))
                {
                    foodGroupCounts[recipe.foodGroup]++;
                }
                else
                {
                    foodGroupCounts.Add(recipe.foodGroup, 1);
                }
            }

            // Clear previous data from the FoodGroupSeries
            FoodGroupSeries.Clear();

            // Add new data to the FoodGroupSeries
            foreach (var kvp in foodGroupCounts)
            {
                FoodGroupSeries.Add(new PieSeries
                {
                    Title = kvp.Key,
                    Values = new ChartValues<int> { kvp.Value },
                    DataLabels = true
                });
            }

            // Set the updated FoodGroupSeries to the pie chart
            pieChart.Series = FoodGroupSeries;
        }
        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
