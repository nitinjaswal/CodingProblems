using System.Collections.Generic;

public class SolutionPascalTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> output = new List<IList<int>>();
        if (numRows == 0)
        {
            return output;
        }
        var previousList = new List<int>();
        previousList.Add(1);

        output.Add(previousList);//List of list to be returned

        for (int i = 1; i < numRows; i++)
        {
            var currentList = new List<int>();//Constructing new liust for every row
            int c = 0;
            foreach (var item in previousList)
            {
                currentList.Add(item + c);//First element will always be 1
                c = item;
            }

            currentList.Add(1);//Last element will always be 1
            output.Add(currentList);
            previousList = currentList;
        }
        return output;

    }
}