using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario39
{
    public class Validador
    {
        public static int PedirInt(string mensaje)
        {
            /* la salida de esta funcion estará en la variable int valor */
            string mensError = "\n\n Por favor ingrese el valor solicitado" +
                               "\n Debe ingresar un valor que no sea vacio y que ese valor sea un número. ";

            int valor;
            
            Console.WriteLine(mensaje);

            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return PedirInt(mensaje);
            }
            else
                return valor;
            
        }

        public static void RegistrarNumero(ref int[] arregloNumero)
        {
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                int numero;

                /*Este Do while verifica que el dato número "x" no se vuelva a ingresar dos veces
                  porque la funcion BuscarNumero verifica que ya hay una posicion para "x"  */
                do
                {
                    
                    numero = PedirInt("\n Ingrese el número " + (i + 1).ToString() + ": ");
                    Console.Clear();
                    if (!(BuscarNumero(arregloNumero,numero) == -1))
                    {
                        Console.Clear();
                        Console.WriteLine("El elemento *" + numero + "* ya existe. Utilice otra forma de nombrarlo");
                    }

                } while (BuscarNumero(arregloNumero, numero) != -1);
                arregloNumero[i] = numero;

            }

        }
        public static int BuscarNumero(int[] arregloNumeros, int numero)
        {
            int posicion = -1;
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                /*Si el nombre ingresado por el usuario coincide con alguno del arreglo se retorna la posicion valida*/
                if (arregloNumeros[i] == numero)
                {
                    posicion = i;
                }
               

            }
            return posicion;
        }

        public static void MostrarListado(int[] arregloNumero)
        {
            /*Console.Clear();*/
            Console.WriteLine("\n Listado de elementos en el Arreglo");
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                Console.WriteLine(" " + arregloNumero[i]);
            }
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}
