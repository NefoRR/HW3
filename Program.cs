using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDataFromKeyboard input = new CheckDataFromKeyboard();

            Console.WriteLine("Enter a range of natural numbers (for example, from 20 to 40), which should contain more than 10 values.");
            Console.WriteLine("Enter 1st number: ");
            int fromNumber = input.CheckNumber();

            Console.WriteLine("Enter 2nd number: ");
            int toNumber = input.CheckNumber();
            while (toNumber < fromNumber + 9) 
            {
                Console.WriteLine("The second number should be 9 more than the first");
                Console.Write("Try again: ");
                toNumber = input.CheckNumber();
            }

            int[] arr = CreateArrayFromTo(fromNumber, toNumber);
            Console.WriteLine("sum of those which are divided by 3 but not divided by 5: " + CalcSumOfDividedByThreeButNotDividedByFive(arr));
            Console.ReadKey();
        }

        public static int CalcSumOfDividedByThreeButNotDividedByFive(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 3 == 0 && item % 5 != 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        private static int[] CreateArrayFromTo(int fromNumber, int toNumber)
        {

            int[] arr = new int[toNumber - fromNumber + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = fromNumber + i;
            }
            return arr;
        }
    }
}


