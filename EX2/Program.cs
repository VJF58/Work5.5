internal class Program
{
    /// <summary>
    /// Записывает слова в строке в обратном порядке и выводит в консоль
    /// </summary>
    /// <param name="inputPhrase">Входная строка</param>
    static void ReversWords(string inputPhrase)
    {
        string[] words = inputPhrase.Split(' ');
        Console.WriteLine(Reverse(words));
    }

    /// <summary>
    /// Принимает массив строк на вход, записывает элементы в обратном порядке и возвращает эти элементы в виде строки
    /// </summary>
    /// <param name="text">Массив слов</param>
    /// <returns></returns>
    static string Reverse(string[] text)
    {
        string temp; //Переменная для временного хранения значений элементов массива
        for (int i = 0; i < text.Length; i++)
        {
            if ((text.Length - 1 - i) <= i) break;

            temp = text[i];
            text[i] = text[text.Length - 1 - i];
            text[text.Length - 1 - i] = temp; // Первый и последний элемент меняются значениями через временную переменную

        }
        return string.Join(' ', text);
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string userString = Console.ReadLine();

        Console.WriteLine("Для продолжения нажмите enter");
        Console.ReadKey();

        ReversWords(userString);
    }
}