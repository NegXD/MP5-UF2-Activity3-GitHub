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
                case ConsoleKey.D4:
                    SistemaSolar();
                    break;
                case ConsoleKey.D5:
                    NameOfTheCapitals();
                    break;
                case ConsoleKey.D6:
                    PermisosYComandosDeWindows();
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
        Console.WriteLine("4 - Questions about solar system");
        Console.WriteLine("5 - Name of the capitals");
        Console.WriteLine("6 - Windows permissions and commands");
        Console.WriteLine()
        Console.WriteLine("0 - EXIT");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    #endregion
    
    public static void SistemaSolar()
    {
        ConsoleKeyInfo tecla;
        MsgNextScreen("Hello, dear user, please answer the following questions on the topic indicated above and answer 5 question");
        int preguntasC = 0;
        int preguntasIn = 0;
        try
        {
            Console.WriteLine("Our solar system");

            Console.WriteLine("Question 1");

            Console.WriteLine("How many planets already in our system? --> ");
            Console.WriteLine("1 - The solar system is not made up of planets it is made up of stars");
            Console.WriteLine("2 - 8 planets");
            Console.WriteLine("3 - 9 planets");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 2 - 8 planets");
            } 

            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 2");

            Console.WriteLine("How many stars does our system have? --> ");
            Console.WriteLine("1 - 1 star");
            Console.WriteLine("2 - 8 stars");
            Console.WriteLine("3 - 2 stars because a one planet is not a planet as such");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 1 - 1 star");
            } 
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 3");

            Console.WriteLine("What is the planet that is in the third position from sercanilla to the sun? --> ");
            Console.WriteLine("1 - Saturn");
            Console.WriteLine("2 - Venus");
            Console.WriteLine("3 - Earth");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D3)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                Console.WriteLine("The correct answer is 3 - Earth");
                preguntasIn++;
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 4");

            Console.WriteLine("What planet do we live on? --> ");
            Console.WriteLine("1 - Neptune");
            Console.WriteLine("2 - Earth");
            Console.WriteLine("3 - Sun");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
               preguntasIn++;
               Console.WriteLine("The correct answer is 2 - Earth");
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 5");

            Console.WriteLine("Which planet is the largest in our system? --> ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Saturn");
            Console.WriteLine("3 - Jupiter");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D3)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 3 - Jupiter");
            }

            Console.WriteLine($"You have corrected {preguntasC} aces failing {preguntasIn} of 5 questions");
           
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }

    }
    
    public static void NameOfTheCapitals()
    {
        ConsoleKeyInfo tecla;
        MsgNextScreen("Hello, dear user, please answer the following questions on the topic indicated above and answer 5 question");
        int preguntasC = 0;
        int preguntasIn = 0;
        try
        {
            Console.WriteLine("Our Name of the capitals");

            Console.WriteLine("Question 1");

            Console.WriteLine("What is the name of the capital of Spain? --> ");
            Console.WriteLine("1 - Madrid");
            Console.WriteLine("2 - Barcelona");
            Console.WriteLine("3 - Aragon");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 1 - Madrid ");
            } 

            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 2");

            Console.WriteLine("What is the name of the capital of Ucraïna ? --> ");
            Console.WriteLine("1 - Kiev");
            Console.WriteLine("2 - Lugansk");
            Console.WriteLine("3 - Jarkov");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 1 - Kiev");
            } 
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 3");

            Console.WriteLine("What is the name of the capital of USA ? --> ");
            Console.WriteLine("1 - Washington DC");
            Console.WriteLine("2 - Nova York");
            Console.WriteLine("3 - Nova Orleans");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                Console.WriteLine("The correct answer is 1 - Washington DC");
                preguntasIn++;
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 4");

            Console.WriteLine("What is the name of the capital of Peru ? --> ");
            Console.WriteLine("1 - Peru");
            Console.WriteLine("2 - Lima");
            Console.WriteLine("3 - Bolivia");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
               preguntasIn++;
               Console.WriteLine("The correct answer is 2 - Lima");
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 5");

            Console.WriteLine("What is the name of the capital of Rusia? --> ");
            Console.WriteLine("1 - Tiumen");
            Console.WriteLine("2 - Moscu");
            Console.WriteLine("3 - Voronezh");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 2 - Moscu");
            }

            Console.WriteLine($"You have corrected {preguntasC} aces failing {preguntasIn} of 5 questions");
           
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
          
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
    
    public static void PermisosYComandosDeWindows()
    {
        ConsoleKeyInfo tecla;
        MsgNextScreen("Hello, dear user, please answer the following questions on the topic indicated above and answer 5 question");
        int preguntasC = 0;
        int preguntasIn = 0;
        try
        {
            Console.WriteLine("Our Windows permissions and commands");

            Console.WriteLine("Question 1");

            Console.WriteLine("What does this command do (cd) ? --> ");
            Console.WriteLine("1 - It is used to change directory, using the formula *cd < DirectoryPath >* to go to the specific directory or folder that you indicate, or *cd..* (with a colon) to exit a folder and go to the beginning level or folder where he was staying.");
            Console.WriteLine("2 - Close the Windows console window");
            Console.WriteLine("3 - It shows all the commands that are available, putting in each one a brief description in English.");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 1 - It is used to change directory, using the formula *cd < DirectoryPath >* to go to the specific directory or folder that you indicate, or *cd..* (with a colon) to exit a folder and go to the beginning level or folder where he was staying");
            } 

            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 2");

            Console.WriteLine("What does this command do rename --> ");
            Console.WriteLine("1 - Be very careful with this last basic command, because it is used to format the unit");
            Console.WriteLine("2 - It allows you to change the name of the file that you consider appropriate, and even including its extension you can also change it.");
            Console.WriteLine("3 - Copy one or more files to the address of your choice.");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 2 - It allows you to change the name of the file that you consider appropriate, and even including its extension you can also change it.");
            } 
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 3");

            Console.WriteLine("What does this command do poweroff ? --> ");
            Console.WriteLine("1 - Is not a Windows command. Is from Linux");
            Console.WriteLine("2 - Open new window");
            Console.WriteLine("3 - Close the Windows console window of a another element");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                Console.WriteLine("The correct answer is 1 - Is not a Windows command. Is from Linux");
                preguntasIn++;
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 4");

            Console.WriteLine("What does this command do dir ? --> ");
            Console.WriteLine("1 - It shows you the directory tree of a specific folder that you tell it");
            Console.WriteLine("2 - The command lists the contents of the directory or folder where you are, showing all the subfolders or files it contains. With this command you will be able to know if the file you are looking for is there or to which subfolder to navigate");
            Console.WriteLine("3 - I don't nou");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
               preguntasIn++;
               Console.WriteLine("The correct answer is 2 - The command lists the contents of the directory or folder where you are, showing all the subfolders or files it contains. With this command you will be able to know if the file you are looking for is there or to which subfolder to navigate");
            }
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 5");

            Console.WriteLine("What does this command do tree? --> ");
            Console.WriteLine("1 - It shows you the directory tree of a specific folder that you tell it");
            Console.WriteLine("2 - It will return the tree of folders below the path where we are, but if we execute it as tree /f, it will also show us all the files that each of the directories contains in the form of a tree as well");
            Console.WriteLine("3 - The command lists the contents of the directory or folder where you are, showing all the subfolders or files it contains. With this command you will be able to know if the file you are looking for is there or to which subfolder to navigate");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.WriteLine("That is the correct answer");
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 2 - It will return the tree of folders below the path where we are, but if we execute it as tree /f, it will also show us all the files that each of the directories contains in the form of a tree as well");
            }

            Console.WriteLine($"You have corrected {preguntasC} aces failing {preguntasIn} of 5 questions");
           
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
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