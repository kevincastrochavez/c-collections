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

    public static void Main(string[] args)
    {
        // Declare 2D array
        string[,] matrix;

        // Two dimensional array
        int[,] array2D = new int[,]
        {
            { 1, 2, 3},
            { 4, 5, 6},
            { 7, 8, 9}
        };

        Console.WriteLine(array2D[0, 0]);

        // Three dimensional array
        int[,,] array3D = new int[,,]
        {
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            },
            {
                { 11, 12, 13},
                { 14, 15, 16},
                { 17, 18, 19}
            }
        };

        Console.WriteLine(array3D[1, 2, 0]);


        // Gets number of dimensions
        int dimension2 = array2D.Rank;
        int dimension3 = array3D.Rank;

        Console.WriteLine(dimension2);
        Console.WriteLine(dimension3);
    }
}