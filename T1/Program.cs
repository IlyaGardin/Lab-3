namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");            
            string? str = Console.ReadLine();

            Console.WriteLine($"Средняя длина слова = {LocalMethods.GetAverageWordLength(str)}");
        }
    }
}
