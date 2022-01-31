using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    class IsValidString
    {


        public static void Main(String[] args)
        {
            int[] temp = { 73, 74, 75, 71, 69, 72, 76, 73 };
            var isValid = DailyTemperatures(temp);
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<int>();
            var result = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    var index = stack.Pop();
                    result[index] = i - index;
                }

                stack.Push(i);
            }

            return result;

        }

    }
}







