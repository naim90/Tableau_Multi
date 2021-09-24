using System;

namespace Tab_multi
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] tableauUniforme1 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int[][] tableauIrregulier1 = new int[3][];

            int NombresDeLigneTableauIrregulier = (tableauIrregulier1.GetUpperBound(0))+1;
            int n = NombresDeLigneTableauIrregulier;

            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    tableauIrregulier1[j] = new int[3] { tableauUniforme1[j, 0], tableauUniforme1[j, 1], tableauUniforme1[j, 2] };
                }
                else if (j == 1)
                {
                    tableauIrregulier1[j] = new int[2] {tableauUniforme1[j, 1], tableauUniforme1[j, 2] };
                    n = n - 1;
                }
                else if (j==2)
                {
                    tableauIrregulier1[j] = new int[1] {tableauUniforme1[j, 2] };
                    n = n - 2;
                }


                for (int i = 0; i < n; i++)
                {


                    Console.Write(tableauIrregulier1[j][i]);


                }

                Console.WriteLine(" ");
                n = NombresDeLigneTableauIrregulier;

            }

      
        }
    }
}
