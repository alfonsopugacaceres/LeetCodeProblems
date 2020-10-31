
namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class SpiralMatrix
    {
        public int[][] generatematrix(int n)
        {
            int target = n * n;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            int counter = 1;
            int xtraversal = 0;
            int ytraversal = 0;
            int xlimit = matrix.Length;
            int ylimit = matrix.Length;
            bool right = true;
            bool left = false;
            bool up = false;
            bool down = false;
            int cycle = 0;
            while (counter < target)
            {
                if (right)
                {
                    if(ytraversal + 1 >= ylimit - cycle)
                    {
                        matrix[xtraversal][ytraversal] = counter;
                        right = false;
                        up = true;
                    }
                    else if (ytraversal < xlimit - cycle)
                    {
                        matrix[xtraversal][ytraversal] = counter;
                        ytraversal++;
                    }
                }
                else if (up)
                {
                    if (xtraversal + 1 >= xlimit - cycle)
                    {
                        matrix[xtraversal][ytraversal] = counter;
                        up = false;
                        left = true;
                    }
                    else if (xtraversal < xlimit - cycle)
                    {
                        xtraversal++;
                        matrix[xtraversal][ytraversal] = counter;
                    }
                }
                else if(left)
                {
                    if (ytraversal - 1 < 0 + cycle)
                    {
                        matrix[xtraversal][ytraversal] = counter;
                        left = false;
                        down = true;
                    }
                    else if (ytraversal >= 0 + cycle)
                    {
                        ytraversal--;
                        matrix[xtraversal][ytraversal] = counter;
                    }
                }
                else if(down)
                {
                    if (ytraversal - 1 > 0 + cycle)
                    {
                        matrix[xtraversal][ytraversal] = counter;
                        cycle++;
                        ylimit = ylimit - 1;
                        xlimit = xlimit - 1;
                        down = false;
                        right = true;
                    }
                    else if (ytraversal >= 0 + cycle + 1)
                    {
                        ytraversal--;
                        matrix[xtraversal][ytraversal] = counter;
                    }
                }
                counter++;
            }
            return matrix;
        }
    }
}
