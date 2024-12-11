namespace Assignment_6_4
{
    internal class Program
    {
        
class RotateMatrix
{
    public static void Rotate(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Number of rows (or columns, since it's square)

        // Step 1: Transpose the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Swap elements at (i, j) and (j, i)
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        // Step 2: Reverse each row
        for (int i = 0; i < n; i++)
        {
            int start = 0, end = n - 1;
            while (start < end)
            {
                // Swap elements in the row
                int temp = matrix[i, start];
                matrix[i, start] = matrix[i, end];
                matrix[i, end] = temp;

                start++;
                end--;
            }
        }
    }

    // Helper function to print the matrix
    public static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

            static void Main(string[] args)
            {
                // Example input matrix
                int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}

            };

                Console.WriteLine("Original Matrix:");
                PrintMatrix(matrix);

                Rotate(matrix);

                Console.WriteLine("\nRotated Matrix (90 degrees clockwise):");
                PrintMatrix(matrix);
            }
        }
    }
}
