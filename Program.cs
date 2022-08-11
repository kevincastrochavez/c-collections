class Program
{
    // public static void Main(string[] args)
    // {
    //     // Array of type int with space for 5 values
    //     int[] grades = new int[5];

    //     grades[0] = 20;
    //     grades[1] = 12;
    //     grades[2] = 23;
    //     grades[3] = 25;
    //     grades[4] = 04;

    //     Console.WriteLine(grades[0]);

    //     // Second way of declaring arrays
    //     int[] gradesOfMathStudentsA = { 20, 12, 23, 25, 04 };

    //     // Third way of declaring arrays
    //     int[] gradesOfMathStudentsB = new int[] { 20, 12, 23, 25, 04, 40 };

    //     Console.WriteLine(grades.Length);
    //     Console.WriteLine(gradesOfMathStudentsA.Length);
    //     Console.WriteLine(gradesOfMathStudentsB.Length);
    // }

    // public static void Main(string[] args)
    // {
    //     int[] nums = new int[10];

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         nums[i] = i;
    //     }

    //     // for (int j = 0; j < nums.Length; j++)
    //     // {
    //     //     Console.WriteLine(nums[j]);
    //     // }

    //     foreach (int item in nums)
    //     {
    //         Console.WriteLine(item);
    //     }

    //     string[] bestFriends = { "Citlalli", "Cindy", "Kevin", "Vanessa", "David"};

    //     foreach (string friend in bestFriends)
    //     {
    //         Console.WriteLine(friend);
    //     }
    // }

    // public static void Main(string[] args)
    // {
    //     // Declare 2D array
    //     string[,] matrix;

    //     // Two dimensional array
    //     int[,] array2D = new int[,]
    //     {
    //         { 1, 2, 3},
    //         { 4, 5, 6},
    //         { 7, 8, 9}
    //     };

    //     Console.WriteLine(array2D[0, 0]);

    //     // Three dimensional array
    //     int[,,] array3D = new int[,,]
    //     {
    //         {
    //             { 1, 2, 3},
    //             { 4, 5, 6},
    //             { 7, 8, 9}
    //         },
    //         {
    //             { 11, 12, 13},
    //             { 14, 15, 16},
    //             { 17, 18, 19}
    //         }
    //     };

    //     Console.WriteLine(array3D[1, 2, 0]);


    //     // Gets number of dimensions
    //     int dimension2 = array2D.Rank;
    //     int dimension3 = array3D.Rank;

    //     Console.WriteLine(dimension2);
    //     Console.WriteLine(dimension3);
    // }

    // public static void Main(string[] args)
    // {
    //     int[,] matrix =
    //     {
    //         { 1, 2, 3 },
    //         { 4, 5, 6 },
    //         { 7, 8, 9 }
    //     };

    //     // Outer loop
    //     for (int i = 0; i < matrix.GetLength(0); i++)
    //     {
    //         // Inner loop
    //         for (int j = 0; j < matrix.GetLength(1); j++)
    //         {
    //             if (matrix[i,j] % 2 != 0)
    //             {
    //                 Console.WriteLine(matrix[i,j]);
    //             }
    //         }
    //     }
    // }

    // public static void Main(string[] args)
    // {
    //     // Declare array and amount of nested arrays
    //     int[][] jaggedArray = new int[3][];

    //     // Assign amount of values to each array
    //     jaggedArray[0] = new int[5];
    //     jaggedArray[1] = new int[3];
    //     jaggedArray[2] = new int[2];

    //     jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
    //     jaggedArray[1] = new int[] { 1, 2, 3 };
    //     jaggedArray[2] = new int[] { 13, 21 };


    //     // Second way
    //     int[][] jaggedArrayTwo = new int[][]
    //     {
    //         new int[] { 2, 3, 5, 7, 11},
    //         new int[] { 1, 2, 3}
    //     };
    // }

    // public static void Main(string[] args)
    // {
    //     string[][] friendsArray = new string[][]
    //     {
    //         new string[] { "Cindy", "Citlalli"},
    //         new string[] { "Hector", "Alicia"},
    //         new string[] { "Jared", "Hector"}
    //     };

    //     Console.WriteLine($"Hi {friendsArray[0][0]}, I would like to introduce {friendsArray[0][1]} to you");
    //     Console.WriteLine($"Hi {friendsArray[1][0]}, I would like to introduce {friendsArray[1][1]} to you");
    //     Console.WriteLine($"Hi {friendsArray[2][0]}, I would like to introduce {friendsArray[2][1]} to you");
    // }

    public static void Main(string[] args)
    {
        int[] gradesArray = new int[] { 15, 13, 8, 12, 6, 16};
        double averageResult = GetAverage(gradesArray);

        Console.WriteLine(averageResult);
        
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum  / size;

            return average;
        }
    }
}