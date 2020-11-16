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
            //PILARES FUNDAMENTALES DE LA PROGRAMACION ESTRUCTURADAS
            //Ejecucion de sentencias secuenciales
            //Uso estructuras repetitivas
            //Uso de estructuras selectivas
            saludos(nombre);
            saludos("Alessandro Gracia");
            saludos("Carlos Perez");

            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuelve valor");
            Console.WriteLine("liquido a recibir para juan {0}", calcularsueldo(300, 200));
            Console.WriteLine("liquido a recibir para Pedro {0}", calcularsueldo(3000, 1520));
            Console.WriteLine("liquido a recibir para Alessandro {0}", calcularsueldo(1000,150));
            Console.WriteLine("      *      ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("   *******   ");
            Console.WriteLine("El cuadrado de 10 es : {0}", (a * a));
            //Imprimir par entre 1 y 10
            for(int i=1; i<=10;i++)
            {

                if (esPar(i) == 1)
                    Console.WriteLine("{0} es par", i);

            }
           //IMprimir Tabla de multiplicar
            for(int i=1;i<=10;i++)
            {
                if (esPar(i) == 1)
                    Console.WriteLine("{0}es par", i);
            }
            Console.WriteLine("Tablas de multiplicar");
            tabla(6);
            Console.WriteLine();
            tabla(5);

            Console.ReadKey();
        }
        //Funciones: subprocesos - Subprogramas - rutinas
        //Dividir el codigo en modulos
        //Ventajas es reutilizar el codigo
        // tipo: Devuelven valores - no devuelven valores

         static void saludos(string nombre) //parametro - argumentos 
        {   
            
            Console.WriteLine("Funcion que no devuelve valores...");
            Console.WriteLine("Hola {0}", nombre);


         }
        //Funcion que devuelve valores
        //La Funcion devuelve un tipo de dato
        static int calcularsueldo(int ingreso, int egreso)
        {
            return (ingreso - egreso);
        }
        //crear la funcion que imprima la siguiente figura
        //    *
        //   ***
        //  *****
        // *******
        static void Figura(string figura)
        {
            Console.WriteLine(figura);
            Console.WriteLine("      *      ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("   *******   ");
        }

        static int cuadrado(int a)
        {
            
            Console.WriteLine("El cuadrado de 10 es : {0}",(a*a));
            int cuadrado = a* a;
            return cuadrado;

        }
        
        static int esPar(int n)
        {
            if (n % 2 == 0)
                return 1;
            else
                return -1;

            // return (n % 2 == 0 ? 1 : -1);

        }
        static void tabla(int n)

        {
            for (int i = 1; i <= 12; i++)
            {

                Console.WriteLine("{0} x {1}= {2}", n, i, (n * i));
            }

        }

    }   
}

