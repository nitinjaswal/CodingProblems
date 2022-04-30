//public class SolutionGuessGame : GuessGame
//{
//    public int GuessNumber(int n)
//    {
//        int low = 0;
//        int high = n;
//        int mid = 0;
//        while (low <= high)
//        {
//            mid = low + (high - low) / 2;
//            int g = guess(mid);
//            if (g == 0)
//            {
//                return mid;
//            }
//            else if (g == 1)
//            {
//                low = mid + 1;
//            }
//            else
//            {
//                high = mid - 1;
//            }
//        }
//        return 0;
//    }
//}