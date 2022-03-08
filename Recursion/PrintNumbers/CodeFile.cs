public class SolutionPrintNumbers
{
    public  void PrintNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }
      //  Console.WriteLine(n);5-4-3-2-1
        PrintNumbers(n - 1);
       // Console.WriteLine(n);1-2-3-4-5
    }
}