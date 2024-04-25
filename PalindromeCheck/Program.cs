internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it's a palindrome: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is the number {number} a palindrome?: {IsPalindrome(number)}");
    }

    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();

        int start = 0;
        int end = numStr.Length - 1;

        while (start < end)
        {
            if (numStr[start] != numStr[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}