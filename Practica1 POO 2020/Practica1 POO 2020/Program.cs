using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_POO_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opc;
            do
            {
                int NumCal, Calf, Cont = 1, S = 0;
                double Prom;

                Console.WriteLine("Bienvenido \n" +
                    "Que programa desea ejecutar? \n" +
                    "1.-Calcular el promedio de numeros \n" +
                    "2.-Calcular la tabla de multiplicar del numero que desee \n" +
                    "3.-Mostrar si un numero es par o impar \n");
                Opc = Convert.ToInt32(Console.ReadLine());
                switch (Opc)
                {
                    case 1:
                        Console.WriteLine("Bienvenido al programa calcular promedio");
                        Console.WriteLine("Cuantas calificaciones desea promediar? ");
                        NumCal = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Ingrese una calificacion: ");
                            Calf = Convert.ToInt32(Console.ReadLine());
                            S = S + Calf;
                            Cont = Cont + 1;
                        } while (Cont <= NumCal);
                        Prom = S / NumCal;
                        Console.WriteLine("El promedio es: " + Prom);
                        Console.WriteLine("Gracias por utilizar el prgrama ");
                        Console.ReadKey();
                        break;
                    case 2:
                        int X, C;
                        Console.WriteLine("Bienvenido al programa Tabla de multiplicar ");
                        Console.WriteLine("De que numero desea mostrar la tabla? ");
                        X = Convert.ToInt32(Console.ReadLine());
                        for (C = 0; C <= 10; C++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", X, C, (X * C));
                        }
                        Console.WriteLine("Gracias por utilizar el programa ");
                        Console.ReadKey();
                        break;
                    case 3:
                        int Num;
                        Console.WriteLine("Bienvenido al programa identificar si un numero es par o impar ");
                        Console.WriteLine("Introduzca el numero: ");
                        Num = Convert.ToInt32(Console.ReadLine());
                        if (Num % 2 == 0)
                        {
                            Console.WriteLine("El numero " + Num + "Es par ");
                        }
                        else
                        {
                            Console.WriteLine("El numero " + Num + "Es impar ");
                        }
                        Console.WriteLine("Gracias por utilizar el programa ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Gracias por utilizar el programa ");
                        break;
                }
                Console.WriteLine("Desea utlizar otro programa? \n" +
                    "1.-Si \n" +
                    "2.-No \n");
                Opc = Convert.ToInt32(Console.ReadLine());
            } while (Opc == 1);
        }
    }
}
