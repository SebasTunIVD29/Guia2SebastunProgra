using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numericos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n****MENU PRINCIPAL****");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Dividision");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Digite el valor segun sea la operacion:[]");
        int opc = Convert.ToInt32(Console.ReadLine());

        //evaluar con switch
        string msj = "";
        double result = 0;
        switch (opc)
        {
            case 1:
                msj = "La suma es : " + (num1 + num2);
                break;
            case 2:
                msj = "La Resta es : " + (num1 - num2);
                break;
            case 3:
                msj = "La Multiplcacion es : " + (num1 * num2);
                break;
            case 4:
                msj = "La Division es : " + (num1 / num2);
                break;
            case 5:
                msj = "Saliendo Del sistema";
                break;

            default:
                msj = "Dijite una opcion Valida";
                break;
        }
        Console.Clear();    
        Console.WriteLine(msj);
        Console.BackgroundColor = ConsoleColor.Green;


    }
}