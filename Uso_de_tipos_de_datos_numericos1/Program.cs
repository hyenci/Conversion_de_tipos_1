using System;

class problemas1
{
    static void Main(string[] args)
    {

        double basei, altura, area;

        Console.WriteLine("PROGRAMA 1");
        Console.WriteLine("\n---------------------------------------------------------------");

        Console.WriteLine("INGRESE LA BASE DEL TRIANGULO");
        basei = double.Parse(Console.ReadLine());

        Console.WriteLine("INGRESE LA ALTURA DEL TRIANGULO");
        altura = double.Parse(Console.ReadLine());
        area = (basei * altura) / 2;

        Console.WriteLine("El área del triángulo es: {0}", +area);

        Console.WriteLine("\n");

        Console.WriteLine("PROGRAMA 2");
        Console.WriteLine("\n---------------------------------------------------------------");


        double radi1, volu;


        Console.WriteLine("INGRESE EL RADIO DE LA ESFERA");
        radi1 = double.Parse(Console.ReadLine());


        volu = (4.0 / 3.0) * Math.PI * Math.Pow(radi1, 3);


        Console.WriteLine("EL RESULTADO DE VOLUMEN DE LA ESFERA ES: {0}", volu);

        Console.WriteLine("PROGRAMA 3");
        Console.WriteLine("\n---------------------------------------------------------------");

        double x1, x2, y1, y2, distancia1;


        Console.WriteLine("INGRESE LA CORDENADA DEL PRIMER PUNTO X : ");
        x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("IGRESE LA CORDENADA DEL PRIMER PUNTO Y : ");
        y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("INGRESE LA CORDENADA DEL SEGUNDO PUNTO X: ");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("INGRESE LA CORDENADA DEL SEGUNDO PUNTO Y ");
        y2 = double.Parse(Console.ReadLine());

        distancia1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));


        Console.WriteLine("LA DISTANCIA ENTRE LOS PUNTOS INGRESADOS ES: {0}", distancia1);


        Console.WriteLine("\n");
        Console.WriteLine("PROGRAMA 4");
        Console.WriteLine("\n---------------------------------------------------------------");


        double temcel, temfa;

        Console.WriteLine("INGRESE LA TEMPERATURA EN GRADOS CELSIUS: ");
        temcel = double.Parse(Console.ReadLine());


        temfa = (temcel * 9 / 5) + 32;

        Console.WriteLine("LA TEMPERATURA EN GRADOS FAHRENHEIT ES: {0}", temfa);

        Console.WriteLine("\n");
        Console.WriteLine("PROGRAMA 5");
        Console.WriteLine("\n---------------------------------------------------------------");

        double tempfa1, temcel1;


        Console.WriteLine("INGRESE LA TEMPERATURA EN GRADOS FAHRENHEIT: ");
        tempfa1 = double.Parse(Console.ReadLine());


        temcel1 = (tempfa1 - 32) * 5 / 9;


        Console.WriteLine("LA TEMPERATURA INGRESADA ES GRADOS CELCIUS ES IGUAL A : {0}", temcel1);


    }
}

