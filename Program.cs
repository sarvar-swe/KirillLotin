class Program
{
    static void Main()
    {
        Console.WriteLine("1. Kirill -> Lotin");
        Console.WriteLine("2. Lotin -> Kirill");
        Console.WriteLine("3. Dasturdan chiqish");

        int menu = int.Parse(Console.ReadLine() !);

        if(menu == 1)
        {
            Console.Write("Enter the kirill word: ");
            
        }
        else if(menu == 2)
        {
            Console.Write("Enter the Lotin word: ");
            Dictionary();
        }
    }

    static void Kirill()
    {
        string word = Console.ReadLine() !;
        string[] a = {word};

    }

    static void Dictionary()
    {
        Dictionary<string, string> kirillDictionary
        = new Dictionary<string, string>()
        {
            {"А", "A"},
            {"Б", "B"},
            {"В", "V"},
            {"Г", "G"},
            {"Д", "D"}, 
            {"Е", "E"},
            {"Ё", "Yo"},
            {"Ж", "Zh"},
            {"З", "Z"},
            {"И", "I"}, 
            {"Й", "Y"},
            {"К", "K"}, 
            {"Л", "L"},
            {"М", "M"},
            {"Н", "N"}, 
            {"О", "O"},
            {"П", "P"},
            {"Р", "R"},
            {"С", "S"},
            {"Т", "T"}, 
            {"У", "U"},
            {"Ф", "F"},
            {"Х", "Kh"},
            {"Ц", "Ts"},
            {"Ч", "Ch"}, 
            {"Ш", "Sh"},
            {"Щ", "Shch"},
            {"Ъ", ""},
            {"Ы", "Y"},
            {"Ь", ""}, 
            {"Э", "E"}, 
            {"Ю", "Yu"}, 
            {"Я", "Ya"},
            {"а", "a"}, 
            {"б", "b"}, 
            {"в", "v"}, 
            {"г", "g"}, 
            {"д", "d"}, 
            {"е", "e"}, 
            {"ё", "yo"}, 
            {"ж", "zh"}, 
            {"з", "z"}, 
            {"и", "i"}, 
            {"й", "y"}, 
            {"к", "k"}, 
            {"л", "l"}, 
            {"м", "m"}, 
            {"н", "n"}, 
            {"о", "o"}, 
            {"п", "p"}, 
            {"р", "r"}, 
            {"с", "s"}, 
            {"т", "t"}, 
            {"у", "u"}, 
            {"ф", "f"}, 
            {"х", "kh"},
            {"ц", "ts"}, 
            {"ч", "ch"}, 
            {"ш", "sh"}, 
            {"щ", "shch"}, 
            {"ъ", ""}, 
            {"ы", "y"}, 
            {"ь", ""}, 
            {"э", "e"}, 
            {"ю", "yu"}, 
            {"я", "ya"}
        };
        

    }
}