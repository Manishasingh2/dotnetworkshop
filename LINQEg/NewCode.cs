using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEg
{
    class LamdatoColl
    {
        public static void main()
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers1.Count(n => n % 2 == 1); 
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers1)}");

            int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstNumbersLessThanSix = numbers2.TakeWhile(n => n < 6);
            Console.WriteLine(string.Join(" ", firstNumbersLessThanSix));

            int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstSmallNumbers = numbers3.TakeWhile((n, index) => n >= index);
            Console.WriteLine(string.Join(" ", firstSmallNumbers));

            var numberSets = new List<int[]>
                    {
                        new[] { 1, 2, 3, 4, 5 },
                        new[] { 0, 0, 0 },
                        new[] { 9, 8 },
                        new[] { 1, 0, 1, 0, 1, 0, 1, 0 }
                    };

            var setsWithManyPositives =
                from numberSet in numberSets
                where numberSet.Count(n => n > 0) > 3
                select numberSet;

           foreach (var numberSet in setsWithManyPositives)
            {
                Console.WriteLine(string.Join(" ", numberSet));
            }
           



        }
    }
}
