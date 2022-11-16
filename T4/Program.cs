
namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string? str = Console.ReadLine();

            Console.WriteLine($"Метод с использованием регулярных выражений: {LocalMethods.ReplaceTagsByRegular(str)}");

            Console.WriteLine($"Метод без использования регулярных выражений: {LocalMethods.ReplaceTagsWithoutRegular(str)}");
        }
    }
}