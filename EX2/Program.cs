using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static string ReversWords(string inputPhrase)
    {
        string[] phrase = SplitText(inputPhrase);
        string temp;


        for (int i = 0; i < phrase.Length; i++)
        {
            if ((phrase.Length - 1 - i) <= i) break;

            temp = phrase[i];
            phrase[i] = phrase[phrase.Length - 1 - i];
            phrase[phrase.Length - 1 - i] = temp; // Первый и последний элемент меняются значениями через временную переменную
        }

        return string.Join(' ', phrase);
    }

    static string[] SplitText(string text)
    {
        string[] words = text.Split(' ');

        return words;
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string userString = Console.ReadLine();

        Console.WriteLine("Для продолжения нажмите enter");
        Console.ReadKey();

        string reversedUserString = ReversWords(userString);

        Console.WriteLine($"Строка с обратным порядком слов - {reversedUserString}");
    }
}