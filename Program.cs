class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст для конвертации (или 'exit' для выхода):");
        string input;

        while ((input = Console.ReadLine()) != "exit")
        {
            Console.WriteLine("Введите '1' для конвертации из кириллицы в латиницу или '2' для конвертации из латиницы в кириллицу:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Результат (Кириллица в Латиница):");
                Console.WriteLine(ConvertCyrillicToLatin(input));
            }
            else if (choice == "2")
            {
                Console.WriteLine("Результат (Латиница в Кириллица):");
                Console.WriteLine(ConvertLatinToCyrillic(input));
            }
            else
            {
                Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте еще раз.");
            }

            Console.WriteLine("\nВведите текст для конвертации (или 'exit' для выхода):");
        }
    }

    static string ConvertCyrillicToLatin(string cyrillic)
    {
        var cyrillicToLatinMap = new Dictionary<char, string>
        {
            {'А', "A"}, {'Б', "B"}, {'В', "V"}, {'Г', "G"}, {'Д', "D"}, 
            {'Е', "E"}, {'Ё', "Yo"}, {'Ж', "Zh"}, {'З', "Z"}, {'И', "I"}, 
            {'Й', "Y"}, {'К', "K"}, {'Л', "L"}, {'М', "M"}, {'Н', "N"}, 
            {'О', "O"}, {'П', "P"}, {'Р', "R"}, {'С', "S"}, {'Т', "T"}, 
            {'У', "U"}, {'Ф', "F"}, {'Х', "Kh"}, {'Ц', "Ts"}, {'Ч', "Ch"}, 
            {'Ш', "Sh"}, {'Щ', "Shch"}, {'Ъ', ""}, {'Ы', "Y"}, {'Ь', ""}, 
            {'Э', "E"}, {'Ю', "Yu"}, {'Я', "Ya"},
            {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, 
            {'е', "e"}, {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"}, 
            {'й', "y"}, {'к', "k"}, {'л', "l"}, {'м', "m"}, {'н', "n"}, 
            {'о', "o"}, {'п', "p"}, {'р', "r"}, {'с', "s"}, {'т', "t"}, 
            {'у', "u"}, {'ф', "f"}, {'х', "kh"}, {'ц', "ts"}, {'ч', "ch"}, 
            {'ш', "sh"}, {'щ', "shch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""}, 
            {'э', "e"}, {'ю', "yu"}, {'я', "ya"}
        };

        string result = string.Empty;
        foreach (char c in cyrillic)
        {
            if (cyrillicToLatinMap.ContainsKey(c))
            {
                result += cyrillicToLatinMap[c];
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    static string ConvertLatinToCyrillic(string latin)
    {
        var latinToCyrillicMap = new Dictionary<string, char>
        {
            {"A", 'А'}, {"B", 'Б'}, {"V", 'В'}, {"G", 'Г'}, {"D", 'Д'}, 
            {"E", 'Е'}, {"Yo", 'Ё'}, {"Zh", 'Ж'}, {"Z", 'З'}, {"I", 'И'}, 
            {"Y", 'Й'}, {"K", 'К'}, {"L", 'Л'}, {"M", 'М'}, {"N", 'Н'}, 
            {"O", 'О'}, {"P", 'П'}, {"R", 'Р'}, {"S", 'С'}, {"T", 'Т'}, 
            {"U", 'У'}, {"F", 'Ф'}, {"Kh", 'Х'}, {"Ts", 'Ц'}, {"Ch", 'Ч'}, 
            {"Sh", 'Ш'}, {"Shch", 'Щ'}, {"Y", 'Ы'}, 
            {"E", 'Э'}, {"Yu", 'Ю'}, {"Ya", 'Я'},
            {"a", 'а'}, {"b", 'б'}, {"v", 'в'}, {"g", 'г'}, {"d", 'д'}, 
            {"e", 'е'}, {"yo", 'ё'}, {"zh", 'ж'}, {"z", 'з'}, {"i", 'и'}, 
            {"y", 'й'}, {"k", 'к'}, {"l", 'л'}, {"m", 'м'}, {"n", 'н'}, 
            {"o", 'о'}, {"p", 'п'}, {"r", 'р'}, {"s", 'с'}, {"t", 'т'}, 
            {"u", 'у'}, {"f", 'ф'}, {"kh", 'х'}, {"ts", 'ц'}, {"ch", 'ч'}, 
            {"sh", 'ш'}, {"shch", 'щ'}, {"y", 'ы'}, 
            {"e", 'э'}, {"yu", 'ю'}, {"ya", 'я'}
        };

        string result = string.Empty;
        string temp = string.Empty;

        for (int i = 0; i < latin.Length; i++)
        {
            temp += latin[i];

            if (latinToCyrillicMap.ContainsKey(temp))
            {
                result += latinToCyrillicMap[temp];
                temp = string.Empty;
            }
            else if (latinToCyrillicMap.ContainsKey(temp.ToLower()))
            {
                result += latinToCyrillicMap[temp.ToLower()];
                temp = string.Empty;
            }
            else if (temp.Length > 2) 
            {
                result += latin[i - 1];
                temp = string.Empty;
            }
        }

        if (!string.IsNullOrEmpty(temp))
        {
            result += temp;
        }

        return result;
    }
}
