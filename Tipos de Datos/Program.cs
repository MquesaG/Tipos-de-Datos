using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de Datos

            int num1, num2;
            byte b= 255;
            short cortos = 65;
            float flotante = 3.14f;
            double dobles  = 56.114523665555544444d;
            decimal deci = 569.45m;
            Boolean boleanos = true; //Falso o verdadero
            string cadena = "Hoy es miercoles 22 de julio";
            char caracter = 's';

            //    Tipo de datos  (var & dinamics)

            var variable = 20;

            dynamic dinamica = 30;
            dinamica = true;
            dinamica = "hola mundo";
            dinamica = 'b';

            int resultado;

            num1 = 5;
            num2 = 8;
            resultado = num1 + num2;

            Console.WriteLine(resultado);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("La suma es de: "+ (num1+ num2));
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("---------------------");
            Console.WriteLine("La resta de {0}-{1} es de {2}", num1, num2, num1 - num2); // Parametro referencia
            //                                                 0     1        2
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------");

            Console.WriteLine($"La multiplicacion de {num1}*{num2}= {num1*num2}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---------------------");
            Console.WriteLine("Digite su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el monto del prestamo:");
            float monto = float.Parse(Console.ReadLine());


            if (monto<=500000)
            {
                monto = monto * 1.05f;
                Console.WriteLine("Digite los meses:");
                int meses = int.Parse(Console.ReadLine());
                float cuota = monto / meses;
                Console.WriteLine($"El monto a pagar por mes es de:{cuota}");
                Console.WriteLine();

            }
            else if (monto>500000 && monto <= 1000000)
            {
                monto = monto * 1.13f;
                Console.WriteLine("Digite los meses:");
                int meses = int.Parse(Console.ReadLine());

                float cuota = monto / meses;
                Console.WriteLine($"El monto a pagar por mes es de:{cuota}");
                Console.WriteLine();

            }


            //int edad = int.Parse(Console.ReadLine());
            //double salario = double.Parse(Console.ReadLine());
            //byte dias = byte.Parse(Console.ReadLine());










            Console.ReadLine(); // La pantalla espera 

        }
    }
}
