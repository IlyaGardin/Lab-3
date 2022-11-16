namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите email: ");
            string? email = Console.ReadLine();

            LocalMethods.PrintCheckEmail(email);
        }
    }
}