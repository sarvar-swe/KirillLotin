using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        CultureInfo culture = new CultureInfo("ru-RU");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentCulture = culture;
        while (true)
        {
            Console.WriteLine("Menu tanlang:");
            Console.WriteLine("1. Kiril --> Lotin");
            Console.WriteLine("2. Lotin --> Kiril");
            Console.WriteLine("3. Dasturdan chiqish");

            string choice = Console.ReadLine()!;

            if (choice == "3")
            {
                Console.WriteLine("Dasturdan chiqilmoqda...");
                break;
            }

            Console.Write("So'zni kiriting: ");
            string input = Console.ReadLine()!;

            if (choice == "1")
            {
                Console.WriteLine("Lotincha tarjimasi: " + KirilToLatin(input));
            }
            else if (choice == "2")
            {
                Console.WriteLine("Kirilcha tarjimasi: " + LatinToKiril(input));
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov! Iltimos, qayta urinib ko'ring.");
            }

            Console.WriteLine();
        }
    }

    static string KirilToLatin(string text)
    {
        // --> Bu erda Kiril harflarini Lotin harflariga almashtirish kodi yozilgan.
        text = text.Replace("А", "A").Replace("Б", "B").Replace("В", "V")
                   .Replace("Г", "G").Replace("Д", "D").Replace("Е", "E")
                   .Replace("Ё", "Yo").Replace("Ж", "J").Replace("З", "Z")
                   .Replace("И", "I").Replace("Й", "Y").Replace("К", "K")
                   .Replace("Л", "L").Replace("М", "M").Replace("Н", "N")
                   .Replace("О", "O").Replace("П", "P").Replace("Р", "R")
                   .Replace("С", "S").Replace("Т", "T").Replace("У", "U")
                   .Replace("Ф", "F").Replace("Х", "X").Replace("Ц", "S")
                   .Replace("Ч", "Ch").Replace("Ш", "Sh").Replace("Щ", "Sh")
                   .Replace("Ъ", "").Replace("Ы", "I").Replace("Ь", "")
                   .Replace("Э", "E").Replace("Ю", "Yu").Replace("Я", "Ya")
                   .Replace("а", "a").Replace("б", "b").Replace("в", "v")
                   .Replace("г", "g").Replace("д", "d").Replace("е", "e")
                   .Replace("ё", "yo").Replace("ж", "j").Replace("з", "z")
                   .Replace("и", "i").Replace("й", "y").Replace("к", "k")
                   .Replace("л", "l").Replace("м", "m").Replace("н", "n")
                   .Replace("о", "o").Replace("п", "p").Replace("р", "r")
                   .Replace("с", "s").Replace("т", "t").Replace("у", "u")
                   .Replace("ф", "f").Replace("х", "x").Replace("ц", "s")
                   .Replace("ч", "ch").Replace("ш", "sh").Replace("щ", "sh")
                   .Replace("ъ", "").Replace("ы", "i").Replace("ь", "")
                   .Replace("э", "e").Replace("ю", "yu").Replace("я", "ya");
        return text;
    }

    static string LatinToKiril(string text)
    {
        // --> Bu erda Lotin harflarini Kiril harflariga almashtirish kodi yozilgan.
        text = text.Replace("Sh", "Ш").Replace("Ch", "Ч").Replace("Ya", "Я")
                   .Replace("Yu", "Ю").Replace("Yo", "Ё").Replace("sh", "ш")
                   .Replace("ch", "ч").Replace("ya", "я").Replace("yu", "ю")
                   .Replace("yo", "ё").Replace("A", "А").Replace("B", "Б")
                   .Replace("V", "В").Replace("G", "Г").Replace("D", "Д")
                   .Replace("E", "Е").Replace("J", "Ж").Replace("Z", "З")
                   .Replace("I", "И").Replace("Y", "Й").Replace("K", "К")
                   .Replace("L", "Л").Replace("M", "М").Replace("N", "Н")
                   .Replace("O", "О").Replace("P", "П").Replace("R", "Р")
                   .Replace("S", "С").Replace("T", "Т").Replace("U", "У")
                   .Replace("F", "Ф").Replace("X", "Х").Replace("a", "а")
                   .Replace("b", "б").Replace("v", "в").Replace("g", "г")
                   .Replace("d", "д").Replace("e", "е").Replace("j", "ж")
                   .Replace("z", "з").Replace("i", "и").Replace("y", "й")
                   .Replace("k", "к").Replace("l", "л").Replace("m", "м")
                   .Replace("n", "н").Replace("o", "о").Replace("p", "п")
                   .Replace("r", "р").Replace("s", "с").Replace("t", "т")
                   .Replace("u", "у").Replace("f", "ф").Replace("x", "х");
        return text;
    }
}