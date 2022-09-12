using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_I
{
    internal class Matrices
    {

        //atributos
        private int[,] matriz;

        //constructores
        public Matrices()
        {
            matriz = new int[3,3]; 

            Random random = new Random();


            // Metodo GetLength(): Requiere de un parametro:
            //                      0. Numero de FILAS
            //                      1. Numero de COLUMNAS
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = random.Next(1,9);
                }
            }
        }

        //constructores
        public Matrices(Boolean p)
        {
            if(p == true)
            {
                matriz = new int[3, 3];

                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    for(int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.WriteLine("Ingrese un numero:  ");
                        int num = int.Parse(Console.ReadLine());
                        matriz[i,j] = num;
                    }
                }
            }
        }

        //constructores
        public Matrices(int[,] m, int[,] n)
        {
            matriz = new int[3,3];

            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < n.GetLength(1); j++)
                {
                    for(int k = 0; k < m.GetLength(0); k++)
                    {
                        matriz[i, j] += m[i, k] * n[k, j];
                    }
                }
            }
        }

        //metodo toString()
        public override string ToString()
        {
            String mostrarMatriz = "";

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    mostrarMatriz += matriz[i, j] + "\t";

                }
                mostrarMatriz += "\n";
            }
            return mostrarMatriz;
        }

        //metodo get
        public int[,] Matriz { get => matriz; /*set => matriz = value*/ }


        static void Main(string[] args)
        {
            Matrices m1 = new Matrices(true);
            Matrices m2 = new Matrices(true);

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            Matrices m3 = new Matrices(m1.Matriz, m2.Matriz);
            Console.WriteLine(m3);

            Console.WriteLine("Press enter to close..."); 
            Console.ReadLine();

        
        }
    }
}
