public class Solution
{
    int count = 0;
    private Dictionary<String, int> map = new Dictionary<String, int>();
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        return CountPaths(obstacleGrid, 0, 0);
    }

    private int CountPaths(int[][] maze, int r, int c)
    {

        if (r > maze.Length - 1 || c > maze[0].Length - 1)
        {
            return 0;
        }
        if (maze[r][c] == 1)
        {
            return 0;
        }

        if (r == maze.Length - 1 && c == maze[0].Length - 1)
        {
            return 1;
        }

        string cell = r + "," + c;
        if (map.ContainsKey(cell))
        {
            return map[cell];
        }

        int down = CountPaths(maze, r: r + 1, c);
        int right = CountPaths(maze, r: r, c: c + 1);

        map[cell] = down + right;
        return down + right;

    }
}