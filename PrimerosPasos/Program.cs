using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipo de datos
            int a,b, suma; // declarar una cariable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);
            Console.ReadKey();

            //tipo de dato: numero en coma flotante
            float sueldo, egreso, total;
            Console.Write("Ingresa el sueldo del trabajador: ");
            sueldo= float.Parse (Console.ReadLine());

            Console.Write("Ingresa los gastos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;

            Console.WriteLine("El Liquido a resivir es: {0}", total);
            Console.ReadKey();
            // case sensitive

            //Tipo de dato flotante de doble precision
            double x1 = 200.3245;
            Console.WriteLine("Tipo de dato double {0}", x1);

            Console.ReadKey();
            
            //Tipo de dato string
            Console.Write("Ingrese tu nombre: ");
            string nombre;
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", Bienvenido al curso de programacion!!");
            Console.ReadKey();
            
            //Tipo de dato Booleano(tipo logico: verdadero/falso)

            bool sw;
            sw = (a+50) > b;
            Console.Write("El valor del booleano sw: {0}", sw);
            Console.ReadKey();
        }

    }
}
