public class SolutionMostWordsFound
{
    public int MostWordsFound(string[] sentences)
    {
        string[] currentBig = new string[sentences.Length];
        int newBig = 0;


        for (int i = 0; i < sentences.Length; i++)
        {
            currentBig = sentences[i].Split(" ");
            if (newBig < currentBig.Length)
            {
                newBig = currentBig.Length;
            }
        }
        return newBig;
    }
}