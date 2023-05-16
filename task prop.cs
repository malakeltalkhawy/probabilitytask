using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter number");
            int n = int.Parse(Console.ReadLine());
            int[] arr  = new  int [n];
            int sum  = 0; 
            for (int i =1 ; i <= n; i++)
            {
                arr[i - 1] = i;
                sum =  sum + i;
            }
            int median;
            if (n % 2 == 0)
            {
                median = (n + 1) / 2;
                Console.WriteLine($"median is:{median}");
            }
            else
            {
                median = (n / 2) + 1;
                Console.WriteLine($"median is:{median}");
            }
            
            int range = arr[n-1] - arr[0];
            Console.Write("range is:");
            Console.WriteLine(range);

            double Q1 = (n ) / 4;
            Console.Write("1 st Q is :");
            Console.WriteLine(Q1);

            double Q3 = (n * 3 )/ 4;
            Console.Write("3 st  is :");
            Console.WriteLine(Q3);

            double P90 = n*0.9;
            Console.Write("P90 is :");
            Console.WriteLine(P90);

            double IQR= Q3-Q1;
            Console.Write("IQR is :");
            Console.WriteLine(IQR);

            double Arithmeticmean = sum / n;

            double mode = 3 * median - 2 * Arithmeticmean;
            Console.Write("mode is :");
            Console.WriteLine(mode);

            double lower = (Q1 - 1.5 * IQR);
            double upper = (Q3 + 1.5 * IQR);
            Console.WriteLine($"outlier is[ {lower}, {upper} ]");
          









        Console.ReadKey();
        }

    }
}
