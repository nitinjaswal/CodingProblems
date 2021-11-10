using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 12, 345, 2, 6, 7896 };
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (checkEven(nums[i].ToString().Length))
                {

                    counter++;

                }

            }


            Console.WriteLine(counter);
            Console.ReadKey();
        }

        private static bool checkEven(int length)
        {
            if (length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
