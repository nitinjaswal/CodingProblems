using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 0 };
            int[] arr2 = { 1 };

            merge(arr1, arr1.Length - arr2.Length, arr2, arr2.Length);
        }


        //Using 3rd array
        //int[] arr3 = new int[nums1.Length + nums2.Length];

        //int i = 0; int j = 0; int k = 0;

        //while (i < nums1.Length - nums2.Length && j < nums2.Length)
        //{
        //    if (nums1[i] <= nums2[j])
        //    {
        //        arr3[k] = nums1[i];
        //        k++;
        //        i++;
        //    }
        //    else
        //    {
        //        arr3[k] = nums2[j];
        //        k++;
        //        j++;
        //    }
        //}

        //for (; i < nums1.Length; i++)
        //{
        //    if (nums1[i] != 0)
        //    {
        //        arr3[k] = nums1[i];
        //        k++;
        //    }


        //}
        //for (; j < nums2.Length; j++)
        //{
        //    arr3[k] = nums2[j];
        //    k++;
        //}

        //nums1 = new int[nums1.Length];
        //for (int x = 0; x <= nums1.Length - 1; x++)
        //{
        //    nums1[x] = arr3[x];
        //}



        public static void merge(int[] nums1, int m, int[] nums2, int n)
        {
            //Here we are using 2 pointers approach and will start filling the array1 from end
            // Set p1 and p2 to point to the end of their respective arrays.
            int p1 = m - 1;
            int p2 = n - 1;

            // And move p backwards through the array, we
            //will write the smallest value in nums1[p] (by comparing p1 and p2)
            
            for (int p = m + n - 1; p >= 0; p--)
            {
                //if index at p2 is -1, means we have iterated al the values in array 2
                if (p2 < 0)
                {
                    break;
                }
                
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1--];
                }
                else
                {
                    nums1[p] = nums2[p2--];
                }
            }
        }
    }

}

