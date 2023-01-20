internal class Program
{
    /// <summary>
    /// Разбивает строку на слова
    /// </summary>
    /// <param name="text">Строка</param>
    /// <returns>Массив слов</returns>
    static string[] SplitText(string text)
    {
        string[] words = text.Split(' ');

        return words;
    }

    /// <summary>
    /// Выводит в консоль массив слов
    /// </summary>
    /// <param name="words">Массив слов</param>
    static void ShowWords(string[] words)
    {
        foreach (string i in words)
        {
            Console.WriteLine(i);
        }
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string userString = Console.ReadLine();

        ShowWords(SplitText(userString));

        Console.ReadKey();
    }
}