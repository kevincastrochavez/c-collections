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

    public static void Main(string[] args)
    {
        int[] nums = new int[10];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i;
        }

        // for (int j = 0; j < nums.Length; j++)
        // {
        //     Console.WriteLine(nums[j]);
        // }

        foreach (int item in nums)
        {
            Console.WriteLine(item);
        }

        string[] bestFriends = { "Citlalli", "Cindy", "Kevin", "Vanessa", "David"};

        foreach (string friend in bestFriends)
        {
            Console.WriteLine(friend);
        }
    }
}