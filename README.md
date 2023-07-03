# ST10024680 Recipe Management Application

This is a Recipe Management application built using WPF (Windows Presentation Foundation). It allows users to capture and store recipe details, display and manipulate recipes, scale recipe values, search recipes by name, and generate a pie chart based on food groups.

## Features

- **Capture Recipe Details:** The application provides a form where users can enter the name of a recipe and its associated details such as quantity, ingredient name, measurement, calories, food group, and recipe steps. The details are saved and displayed in a list.

- **Display and Manipulate Recipes:** The application allows users to view and manipulate the stored recipes. Users can scale the values of all recipes by a factor of 0.5, 2, or 3. They can also reset the recipe list to its original values. Additionally, users can search for recipes by name and view the matching recipes along with their details.

- **Generate Pie Chart:** The application provides a pie chart visualization of the recipes based on their food groups. The chart shows the distribution of recipes across different food groups.

## How to Use

1. Launch the application by running the executable file or by running the project in a suitable development environment.

2. The main window will appear, allowing you to enter recipe names. Enter the desired recipe names and click the "Save Recipe" button to capture them. The recipe names will be stored and sorted in ascending order.

3. To add details for a recipe, click the "Add Description" button. A form will open where you can enter the recipe details. Fill in the required fields and click the "Save" button to add the recipe. The details will be displayed in a list.

4. To view and manipulate the stored recipes, click the "Menu" button. The menu window will open, offering several options.

5. Click the "Search" button to search for recipes by name. Enter the recipe name in the search box and click "Search." The matching recipes will be displayed, along with their details.

6. Click the "Scale" buttons to scale the recipe values by a factor of 0.5, 2, or 3. This will update the recipe values in the list.

7. Click the "Reset" button to reset the recipe list to its original values.

8. Click the "Chart" button to open a window displaying a pie chart visualization of the recipes based on their food groups.

9. Close the application by clicking the "Exit" button.

## Dependencies

The application utilizes the LiveCharts library for generating the pie chart visualization. Make sure the required dependencies are installed or included in the project.

## Acknowledgements

This application was created by Enesto VanWyk as a programming assignment for  PROG6221.

Please note that this README file provides a general overview of the application and its functionalities. For more detailed information, refer to the source code and comments in the individual classes.