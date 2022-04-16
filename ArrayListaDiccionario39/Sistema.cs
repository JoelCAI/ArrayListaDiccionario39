using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario39
{
    public class Sistema
    {

        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            int[] arregloNumero = new int[cantidad];

            Validador.RegistrarNumero(ref arregloNumero);

            Validador.MostrarListado(arregloNumero);

            Array.Reverse(arregloNumero);

            Console.WriteLine("\n Aplicamos el orden inverso y obtenemos: ");
            Validador.MostrarListado(arregloNumero);

            Validador.Despedida();

        }

        public const int cantidad = 3;

        public void Iniciar()
        {
            MenuPrincipal();
        }
        




        
    }

    
}
