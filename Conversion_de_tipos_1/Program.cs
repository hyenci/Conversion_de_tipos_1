using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("PROGRAMA 1");
        Console.Write("\n---------------------------------------------------------------");
        Console.Write("\nINGRESE UN NUMERO ENTERO");
        Console.Write("\n");
        int numE = Convert.ToInt32(Console.ReadLine());

        decimal numdi = Convert.ToDecimal(numE);


        Console.WriteLine($"EL RESULTADO ES: {numdi}");

        Console.Write("\n---------------------------------------------------------------");
        Console.Write("\nPROGRAMA 2");

        Console.Write("\nINGRESE NUMERO DECIMAL:");
        Console.Write("\n");
        decimal numdeci1 = Convert.ToDecimal(Console.ReadLine());
        float numfloati = (float)numdeci1;

        Console.WriteLine($"\n EL RESULTADO ES: {numfloati}>>> ");

        Console.Write("\n---------------------------------------------------------------");
        Console.Write("\nPROGRAMA 3");

        Console.Write("\nINGRESE UN NUMERO FLOTANTE");
        Console.Write("\n");
        float numflofli = Convert.ToSingle(Console.ReadLine());


        int num2 = (int)Math.Round(numflofli);
        Console.WriteLine($"\n EL RESULTADO ES: {numflofli}");
        Console.Write("\n---------------------------------------------------------------");
        Console.Write("\nPROGRAMA 4");
        Console.Write("\nINGRESE UN CARACTER");

        Console.Write("\n");
        char cara1 = Console.ReadKey().KeyChar;

        int numE21 = (int)cara1;
        Console.WriteLine($"\n EL RESULTADO ES: > {numE21}");
        Console.Write("\n---------------------------------------------------------------");
        Console.Write("\nPROGRAMA 5");
        Console.Write("\nINGRESE UN ENTERO");

        Console.Write("Ingrese un número entero: ");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());


        char caracter;
        if (Char.IsLetter((char)numeroEntero))
        {
            caracter = (char)numeroEntero;
            Console.WriteLine($"EL NUMERO {numeroEntero} EN CARACTER ES {caracter}");
        }
        else
        {
            Console.WriteLine("DIGITE OTRO NUMERO");
        }




    }
}

