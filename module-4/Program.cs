using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        var temp = 0;

        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
                for (int k = j + 1; k <= array.GetUpperBound(1); k++)
                    if (array[i, j] > array[i, k])
                {
                        temp = array[i, k];
                        array[i, k] = array[i, j];
                        array[i, j] = temp;
                }
        }
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}

