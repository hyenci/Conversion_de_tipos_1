using System;

class Program
{
    static void Main()
    {
        Console.Write("PROGRAMA 1");
        Console.WriteLine("\n---------------------------------------------------------------");

        Console.WriteLine("INGRESE EL PRIMER NUMERO PARA REALIZAR LA SUMA:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("INGRESE EL SEGUNDO NUMERO PARA REALIZAR LA SUMA:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int suma = num1 + num2;

        Console.WriteLine("EL RESULTADO ES : " + suma);






        Console.Write("PROGRAMA 2");
        Console.WriteLine("\n---------------------------------------------------------------");
        Console.WriteLine("INGRESE EL PRIMER NUMERO DECIMAL PARA REALIZAR LA RESTA");
        double numI1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL SEGUNDO NUMERO DECIMAL PARA REALIZAR LA RESTA");
        double numI2 = Convert.ToDouble(Console.ReadLine());

        double resta = numI1 - numI2;

        Console.WriteLine(" EL RESULTADO DE LA RESTA ES:>>" + resta);
        Console.WriteLine("PROGRAMA 3");
        Console.WriteLine("\n---------------------------------------------------------------");
        Console.WriteLine("INGRESE EL PRIMER NUMERO FLOTANTE PARA REALIZAR LA MULTIPLICACION");

        float nume1 = float.Parse(Console.ReadLine());

        Console.WriteLine("INGRESE EL SEGUNDO NUMERO FLOTANTE PARA REALIZAR LA MULTIPLICACION");

        float nume2 = float.Parse(Console.ReadLine());

        float resultado = nume1 * nume2;
        Console.WriteLine(">>>>>>");
        Console.WriteLine($"EL RESULTADO DE LA MULTIPLICACION ES: >" + resultado);

        Console.WriteLine("PROGRAMA 4");
        Console.WriteLine("\n---------------------------------------------------------------");
        Console.WriteLine("INGRESE EL PRIMER NUMERO PARA REALIZAR LA DIVISION");
        int numir1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("INGRESE EL SEGUNDO NUMERO PARA REALIZAR LA DIVISION");
        int numir2 = Convert.ToInt32(Console.ReadLine());
        int divi = numir1 / numir2;
        Console.WriteLine($"EL RESULTADO DE LA DIVISIÓN ES: " + divi);

        Console.WriteLine("");
        Console.WriteLine("PROGRAMA 5");
        Console.WriteLine("\n---------------------------------------------------------------");
        Console.WriteLine("INGRESE EL PRIMER NUMERO PARA OBTENER EL RESIDUO DE LA DIVISION");
        int numeris1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("INGRESE EL SEGUNDO NUMERO PARA OBTENER EL RESIDUO DE LA DIVISION");
        int numeris2 = Convert.ToInt32(Console.ReadLine());
        int resulti = numeris1 % numeris2;
        Console.WriteLine($"EL RESIDUO DE LA DIVISION ES:" + resulti);







    }
}

