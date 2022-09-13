using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tipo = string.Empty;
            int Conteo = 1;
            int ConteoOper = 1;
            int Conteo2 = 20;
            string Decision = string.Empty;
            Console.WriteLine("!HOLA¡, BIENVENIDO, ESCOGE LA ACCION QUE DESEAS REALIZAR. ");

            for (int i = 0; i < Conteo; i++)
            {
                Console.WriteLine("Valores de la operacion soportadas ");
                Console.WriteLine('\n' +
                    "Resta = 1" + '\n' +
                    "Suma = 2" + '\n' +
                    "Division = 3" + '\n' +
                    "Multiplicacion = 4" + '\n');
                Console.WriteLine("Ingrese el numero de la operacion correspondiente a realizar: ");

                Tipo = Console.ReadLine();

                if (Tipo == "1")
                {
                    for (int j = 0; j < ConteoOper; j++)
                    {
                        Console.Write("RESTA" + '\n');
                        Console.Write("Inserte un valor: ");
                        int numero;
                        int numero2;

                        numero = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        int Resultado = (int)numero - numero2;

                        Console.WriteLine("El resultado es " + Resultado);
                        Console.WriteLine("¿Desea Realizar otra operacion de resta Y O N?");
                        Decision = Console.ReadLine();
                        if (Decision == "Y")
                            ConteoOper++;
                        else
                            ConteoOper = 0;
                    }

                    Console.WriteLine("¿Desea Realizar otra operacion Y O N?");
                    Decision = Console.ReadLine();
                    if (Decision == "Y")
                        Conteo++;
                    else
                        Conteo = 0;

                }
                if (Tipo == "2")
                {
                    for (int j = 0; j < ConteoOper; j++)
                    {
                        Console.Write("SUMA" + '\n');
                        Console.Write("Inserte un valor: ");
                        int numero;
                        int numero2;

                        numero = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        int Resultado = numero + numero2;

                        Console.WriteLine("El resultado es " + Resultado);
                        Console.WriteLine("¿Desea Realizar otra operacion de resta Y O N?");
                        Decision = Console.ReadLine();
                        if (Decision == "Y")
                            ConteoOper++;
                        else
                            ConteoOper = 0;
                    }

                    Console.WriteLine("¿Desea Realizar otra operacion Y O N?");
                    Decision = Console.ReadLine();
                    if (Decision == "Y")
                        Conteo++;
                    else
                        Conteo = 0;

                }
                if (Tipo == "3")
                {
                    for (int j = 0; j < ConteoOper; j++)
                    {
                        Console.Write("DIVISION" + '\n');
                        Console.Write("Inserte un valor: ");
                        int numero;
                        int numero2;

                        numero = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        decimal Resultado = (decimal)numero / numero2;

                        Console.WriteLine("El resultado es " + Resultado);
                        Console.WriteLine("¿Desea Realizar otra operacion de resta Y O N?");
                        Decision = Console.ReadLine();
                        if (Decision == "Y")
                            ConteoOper++;
                        else
                            ConteoOper = 0;

                    }
                    Console.WriteLine("¿Desea Realizar otra operacion Y O N?");
                    Decision = Console.ReadLine();
                    if (Decision == "Y")
                        Conteo++;
                    else
                        Conteo = 0;

                }
                if (Tipo == "4")
                {
                    for (int j = 0; j < ConteoOper; j++)
                    {
                        Console.Write("MULTIPLICACION" + '\n');
                        Console.Write("Inserte un valor: ");
                        int numero;
                        int numero2;

                        numero = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        int Resultado =(int) numero * numero2;


                        Console.WriteLine("El resultado es " + Resultado);
                        Console.WriteLine("¿Desea Realizar otra operacion de resta Y O N?");
                        Decision = Console.ReadLine();
                        if (Decision == "Y")
                            ConteoOper++;
                        else
                            ConteoOper = 0;
                    }
                    Console.WriteLine("¿Desea Realizar otra operacion Y O N?");
                    Decision = Console.ReadLine();
                    if (Decision == "Y")
                        Conteo++;
                    else
                        Conteo = 0;

                }

                if (Tipo != "1" && Tipo != "2" && Tipo != "3" && Tipo != "4")
                {
                    string Punto = ".";
                    string Choice = string.Empty;
                    Console.WriteLine("Opcion Invalida");
                    Console.WriteLine("¿Desea intentarlo de nuevo?");
                    Choice = Console.ReadLine();
                    if (Choice == "Y")
                        Conteo++;
                    else
                    {
                        Console.Write("Adios");
                        for (int i1 = 0; i1 < Conteo2; i1++)
                        {
                            Console.Write(Punto);
                        }
                    }

                }
            }
          
        }
    }
}