using System;
namespace Full_GRASP_And_SOLID.Library;

public class ConsolePrinter
{
    public void Printer(Recipe recipe)
    {
        Console.WriteLine(recipe.Text());
    }
}
/*
Separé esta clase para que se cumpla con el SRP, debido a que recipe tenía 2 responsabilidades
sino se agregaba este cambio. Además, si el día de mañana quiero imprimir en otro lado iba a 
generar problemas.
*/