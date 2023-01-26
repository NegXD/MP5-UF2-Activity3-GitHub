internal class Program
{
    #region Main
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    CShareQuiz();
                    break;
                case ConsoleKey.D0:
                    MsgNextScreen("PRESS ANY KEY TO EXIT");
                    break;
                default:
                    MsgNextScreen("ERROR. PRESS ANY KEY TO RETURN TO THE MENU");
                    break;
            }
        }
        while (tecla.Key != ConsoleKey.D0);
    }

    #endregion

    #region Show Options and Message Next Screen
    public static void ShowOptions()
    {
        Console.WriteLine("1 - C# QUEST");
        Console.WriteLine();
        Console.WriteLine("0 - EXIT");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    #endregion

    public static void CShareQuiz()
    {
        ConsoleKeyInfo key;
        int count = 0;
        try
        {
            Console.WriteLine("C# is a [] paradigms");
            Console.WriteLine("1. \tSimple");
            Console.WriteLine("2. \tTriple");
            Console.WriteLine("3. \tMultiple");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
            Console.Clear();

            Console.WriteLine("The first year that appeared C# is ");
            Console.WriteLine("1. \t1998");
            Console.WriteLine("2. \t2000");
            Console.WriteLine("3. \t2003");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D2) count++;
            Console.Clear();

            Console.WriteLine("C# is from ");
            Console.WriteLine("1. \tMinecrosoft");
            Console.WriteLine("2. \tMincrosoft");
            Console.WriteLine("3. \tMicrosoft");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
            Console.Clear();

            Console.WriteLine("Who is the creator of C#? ");
            Console.WriteLine("1. \tAnders Hejlsberg");
            Console.WriteLine("2. \tNiklaus Wirth");
            Console.WriteLine("3. \tMads Torgersen");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) count++;
            Console.Clear();

            Console.WriteLine("The file extension of C# is ");
            Console.WriteLine("1. \t.cs .csx .cshtml .razor");
            Console.WriteLine("2. \t.cs .csx .cshtml .csprogram");
            Console.WriteLine("3. \t.cs .csx .cshtml .crl");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) count++;
            Console.Clear();

            Console.WriteLine($"You have {count} of 5 points");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }
}