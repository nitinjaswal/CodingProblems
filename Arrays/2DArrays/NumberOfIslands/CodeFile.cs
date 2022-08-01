public class SolutionNumIslands
{
    public int NumIslands(char[][] grid)
    {

        if (grid.Length == 0)
        {
            return 0;
        }
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    DFS(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }
    private void DFS(char[][] grid, int row, int col)
    {
        if (row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length && grid[row][col] == '1')
        {
            //if element is 1 then set to '0'
            grid[row][col] = '0';

            //Call in all 4 directions
            DFS(grid, row + 1, col);
            DFS(grid, row - 1, col);
            DFS(grid, row, col + 1);
            DFS(grid, row, col - 1);
        }
    }
}