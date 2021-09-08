using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
        //Cree otra clase llamada Console Prienter para sacarle resposablidad a la clase recipie
    }
}