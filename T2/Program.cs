namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string? str = Console.ReadLine();

            LocalMethods.PrintIsPalindrome(str);
        }
    }
}
