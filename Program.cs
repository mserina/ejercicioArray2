using System.ComponentModel;

namespace ejercicio2Arraymsm
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila = 10;
            int conlumna = 10;
            int celdas = 101;

            int[,] matriz = new int [fila, conlumna];

            //filas
            for ( int i= 0; i < fila; i++)
            {
                for (int j = 0; j < conlumna; j++)
                {
                    matriz[i, j] = celdas;
                    celdas--;
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine("|");
            }


            for (int i= 0;i < 101; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}