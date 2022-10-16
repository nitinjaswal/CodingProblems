// Selection sort
// You need to select the smallest element in the array and move it to the beginning of the array by swapping with the front element.
// Time complexity O(n^2) and Space Complexity O(1)
public class SelectionSort
{
    static void SelecSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {

            int min = i;

            // Findng smallest element in the array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            if (arr[min] < arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
