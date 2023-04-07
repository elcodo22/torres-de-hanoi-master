using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torres de Hanoi");
            Console.WriteLine();
            Console.WriteLine("¿Cuántos discos quieres?");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Has seleccionado " + numero + " discos");
            Console.WriteLine();

            Pila ini = new Pila(numero);
            Pila aux = new Pila();
            Pila fin = new Pila();

            Console.WriteLine("i interativo o r recursivo");
            Console.WriteLine();

            string modo = Console.ReadLine();


            if (modo.Equals("i"))
            {
                Console.WriteLine("Modo interativo");
                Console.WriteLine();
            }
            else if (modo.Equals("r"))
            {
                Console.WriteLine("Modo recursivo");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ningún modo seleccionado");
                Console.WriteLine();
            }

            Console.WriteLine("Inicial");
            Console.Write("INI: ");

            for (int i = 0; i <= ini.Size - 1; i++)
            {
                string ini_disco = ini.Elementos[i].Valor != null ? ini.Elementos[i].Valor.ToString() : " ";
                if (i == ini.Size - 1)
                {
                    Console.Write(ini_disco);
                }
                else if (ini.Size != 1)
                {
                    Console.Write(ini_disco + ", ");
                }
            }
            Console.WriteLine();
            Console.Write("AUX: ");
            for (int i = 0; i <= aux.Size - 1; i++)
            {
                string aux_disco = aux.Elementos[i].Valor != null ? aux.Elementos[i].Valor.ToString() : " ";
                if (i == aux.Size - 1)
                {
                    Console.Write(aux_disco);
                }
                else if (aux.Size != 1)
                {
                    Console.Write(aux_disco + ", ");
                }
            }
            Console.WriteLine();
            Console.Write("FIN: ");
            for (int i = 0; i <= fin.Size - 1; i++)
            {
                string fin_disco = fin.Elementos[i].Valor != null ? fin.Elementos[i].Valor.ToString() : " ";
                if (i == fin.Size - 1)
                {
                    Console.Write(fin_disco);
                }
                else if (fin.Size != 1)
                {
                    Console.Write(fin_disco + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            int movimientos = 0;

            if (modo.Equals("i"))
            {

                movimientos = new Hanoi().iterativo(numero, ini, fin, aux);
            }
            else if (modo.Equals("r"))
            {
                movimientos = new Hanoi().recursivo(numero, ini, fin, aux);
            }

            Console.WriteLine();
            Console.WriteLine("Para " + numero + " piezas se han necesitado " + movimientos + " movimientos");
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
