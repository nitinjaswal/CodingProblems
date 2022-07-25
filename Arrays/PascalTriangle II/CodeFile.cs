using System.Collections.Generic;

public class SolutionPascalTriangleGetRow
{
    public IList<int> GetRow(int numRows)
    {
        var previousList = new List<int>();
        previousList.Add(1);

        for (int i = 1; i <= numRows; i++)
        {
            var currentList = new List<int>();//Constructing new liust for every row
            int c = 0;
            foreach (var item in previousList)
            {
                currentList.Add(item + c);//First element will always be 1
                c = item;
            }

            currentList.Add(1);//Last element will always be 1
            previousList = currentList;
        }
        return previousList;
    }
}