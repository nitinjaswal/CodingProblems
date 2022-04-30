/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

//public class SolutionFirstBadVersion : VersionControl
//{
//    public int FirstBadVersion(int n)
//    {
//        int low = 0;
//        int high = n;
//        int mid = 0;
//        while (low <= high)
//        {
//            mid = low + (high - low) / 2;

//            if (IsBadVersion(mid))
//            {
//                high = mid - 1;
//            }
//            else
//            {
//                low = mid + 1;
//            }
//        }
//        return low;
//    }
//}