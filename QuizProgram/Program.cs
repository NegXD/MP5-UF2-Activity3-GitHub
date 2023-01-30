public class Program
{
    #region Main
    public static void Main(string[] args)
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
                case ConsoleKey.D2:
                    WorldMapQuiz();
                    break;
                case ConsoleKey.D3:
                    LinuxCommandQuiz();
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
        Console.WriteLine("2 - WORLD MAP QUEST");
        Console.WriteLine("3 - LINUX COMMANDS QUEST");
        Console.WriteLine();
        Console.WriteLine("0 - EXIT");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    #endregion

    #region C# Quest
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

    #endregion

    #region 

    public static void WorldMapQuiz()
    {
        ConsoleKeyInfo key;
        int count = 0;
        try
        {
            Console.WriteLine("In the world map were is Austraria located?");
            Console.WriteLine("1. \t In the left part of the map");
            Console.WriteLine("2. \t In the right part of the map");
            Console.WriteLine("3. \t In the bottom part of the map");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D2) count++;
            Console.Clear();

            Console.WriteLine("Who is the creator of the first world map? ");
            Console.WriteLine("1. \t Hejlsberg");
            Console.WriteLine("2. \t Niklaus");
            Console.WriteLine("3. \t Anaximandro");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
            Console.Clear();

            Console.WriteLine("The first world map (anaximandro) appeared is in ");
            Console.WriteLine("1. \t 1323 B.C.");
            Console.WriteLine("2. \t 520 B.C.");
            Console.WriteLine("3. \t 129 A.D.");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D2) count++;
            Console.Clear();

            Console.WriteLine("In the map Anaximandro which continent is not appeared");
            Console.WriteLine("1. \t American");
            Console.WriteLine("2. \t Africa");
            Console.WriteLine("3. \t Asia");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) count++;
            Console.Clear();

            Console.WriteLine("Were is antartida");
            Console.WriteLine("1. \tIn the left part of the map");
            Console.WriteLine("2. \tIn the right part of the map");
            Console.WriteLine("3. \tIn the bottom part of the map");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
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

    #endregion

    #region

    public static void LinuxCommandQuiz()
    {
        ConsoleKeyInfo key;
        int count = 0;
        try
        {
            Console.WriteLine("What is the ls command for?");
            Console.WriteLine("1. \t To see what's in a directory");
            Console.WriteLine("2. \t To see what's in a file");
            Console.WriteLine("3. \t To see what's in a main directory");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) count++;
            Console.Clear();

            Console.WriteLine("What is the variable -al in the ls command");
            Console.WriteLine("1. \t list files with detailed information ");
            Console.WriteLine("2. \t List directories with detailed information");
            Console.WriteLine("3. \t List files and directories with detailed information");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
            Console.Clear();

            Console.WriteLine("What does the command head does?");
            Console.WriteLine("1. \t View the lines of any text file");
            Console.WriteLine("2. \t View the first few lines of any text file");
            Console.WriteLine("3. \t view the half lines of any text file");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D2) count++;
            Console.Clear();

            Console.WriteLine("What does the command diff does?");
            Console.WriteLine("1. \t Compares the weight of two files");
            Console.WriteLine("2. \t Compares the character of two files");
            Console.WriteLine("3. \t Compares the contents of two files line by line");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D3) count++;
            Console.Clear();

            Console.WriteLine("What does the command rsync does?");
            Console.WriteLine("1. \t Transfers and synchronizes files or directories");
            Console.WriteLine("2. \t Synchronizes files or directories");
            Console.WriteLine("3. \t Transfers files or directories");
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

    #endregion
}