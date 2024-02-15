using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA 1");
        Console.WriteLine("\n---------------------------------------------------------------");

        Console.WriteLine("INGRESE UNA ORACION EN MINUSCULAS:");
        string cadena = Console.ReadLine();


        string cadenueva = cadena.ToUpper();


        Console.WriteLine("LA CADENA EN MAYUSCULAS:");
        Console.WriteLine(cadenueva);
        Console.WriteLine("\n");

        Console.WriteLine("PROGRAMA 2");
        Console.WriteLine("\n---------------------------------------------------------------");
        Console.WriteLine("INGRESE UNA ORACION EN MAYUSCULAS");
        string cadeni1 = Console.ReadLine();
        string cadenueva1 = cadeni1.ToLower();
        Console.WriteLine("LA NUEVA CADENA EN MINUSCULAS ES :");
        Console.WriteLine(cadenueva1);
        Console.WriteLine("\n");
        Console.WriteLine("PROGRAMA 3");
        Console.WriteLine("\n---------------------------------------------------------------");


        Console.WriteLine("INGRESE UNA ORACIÓN");
        string cadenita1 = Console.ReadLine();


        char[] oraci1 = cadenita1.ToCharArray();
        Array.Reverse(oraci1);


        string cadereversa = new string(oraci1);


        Console.WriteLine("LA ORACION AL REVES ES :");
        Console.WriteLine(cadereversa);
        Console.WriteLine("\n");
        Console.WriteLine("PROGRAMA 4");
        Console.WriteLine("\n---------------------------------------------------------------");

        Console.WriteLine("INGRESE UNA ORACION");
        string cadi11 = Console.ReadLine();


        Console.WriteLine("INGRESE LA PALABRA DE LA ORACION QUE QUIERE BUSCAR");
        string palabra = Console.ReadLine();


        bool palabrasi = cadi11.Contains(palabra);


        if (palabrasi)
        {
            Console.WriteLine($"LA PALABRA '{palabra}' SE ENCONTRO CON EXITO");
        }
        else
        {
            Console.WriteLine($"LA PALABRA'{palabra}'NO SE ENCONTRO");
        }
        Console.WriteLine("\n");

        Console.WriteLine("PROGRAMA 5");
        Console.WriteLine("\n---------------------------------------------------------------");

        Console.WriteLine("INTRODUZCA UNA ORACIÓN ");
        string cadenita13 = Console.ReadLine();


        int numvocales = Regex.Matches(cadenita13, "[aeiouAEIOU]", RegexOptions.IgnoreCase).Count;


        Console.WriteLine("La cadena tiene {0} vocales", numvocales);




    }
}
