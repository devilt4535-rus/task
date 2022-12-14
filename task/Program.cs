internal class Program
{
    private static void Main(string[] args)
    {
         Numder number = new();
        int[] arrayNumbers = new int[] { 2, 2, 2, 1, 2, 2, 2, 2, 2 };
        number.FindUniqueNumberArray(arrayNumbers);
    }
}

