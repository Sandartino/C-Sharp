using System;
					
public class Program
{
	public static void Main()
	{
	int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int allWidth = 3 * n + 1;
        int eggWidth = 3 * n - 1;
        char[,] matrix = new char[height, allWidth];
        FillMatrix(height, allWidth, matrix);

        int pivot=n+1;
        for (int row = 0; row <1 ; row++)
        {
            for (int i = 0; i < n-1; i++)
            {
                matrix[row, pivot] = '*';
                matrix[height-1, pivot] = '*';
                pivot++;
            }          
        }
        int stars = n - 1;
        int starsBottom = height - 1;
        int irow=1;
        for (; irow <= n/2; irow++)
        {
            for (int i = 0; i < 1; i++)
            {
                matrix[irow, stars] = '*';
                matrix[starsBottom-1, stars] = '*';
                stars -= 2;
                starsBottom--;
                matrix[irow, pivot+1] = '*';
                matrix[starsBottom, pivot + 1] = '*';
                pivot += 2;
            }
        }

        int counter = n - 2;
        for (int i = 0; i < n-2; i++)
        {
            for (int k = 0; k <1; k++)
            {
               
                matrix[irow, 1] = '*';
                matrix[irow, pivot-1] = '*';
                    irow++;
            }
        }

        int counterPivot = 2;
        int counterF = n - 1;
        int sub = n / 2 + n;
        for (int l = 0; l < 1; l++)
        {
            for (int i = 1; i <=eggWidth-2; i++)
            {                               
                if (counterPivot % 2 == 1)
                {
                    matrix[counterF, counterPivot] = '.';
                    counterF++;
                    matrix[counterF, counterPivot] = '@';
                    counterF--;
               
                }
                else
                {
                    matrix[counterF, counterPivot] = '@';
                    counterF++;
                    matrix[counterF, counterPivot] = '.';
                    counterF--;
              
                }
                counterPivot++;
            }
            
        }
        PrintMatrix(height, allWidth, matrix);
    }

    static void PrintMatrix(int height, int allWidth, char[,] matrix)
    {
        for (int i = 0; i < height; i++)
        {
            for (int k = 0; k < allWidth; k++)
            {
                Console.Write(matrix[i, k]);
            }
            Console.WriteLine();
        }
    }

    static void FillMatrix(int height, int allWidth, char[,] matrix)
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < allWidth; col++)
            {
                matrix[row, col] = '.';
            }
        }
    }
}
