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
                case ConsoleKey.D4:
                    SistemaSolar("4 - Questions about solar system");
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
        Console.WriteLine("");
        Console.WriteLine();
        Console.WriteLine("0 - EXIT");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    #endregion
    public string void MensageDeEx(string mde)
    {
        Console.WriteLine(mde);
        Console.ReadKey();
    }
    public string void SistemaSolar()
    {
        ConsoleKeyInfo tecla;
        MensageDeEx("Hello, dear user, please answer the following questions on the topic indicated above and answer 5 question");
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
            if (tecla.Key == ConsoleKey.D2)
            {
                preguntasC++;
            }
            else preguntasIn++;

            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 2");

            Console.WriteLine("How many stars does our system have? --> ");
            Console.WriteLine("1 - 1 star");
            Console.WriteLine("2 - 8 stars");
            Console.WriteLine("3 - 2 stars because a one planet is not a planet as such");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D1)
            {
                preguntasC++;
            }
            else preguntasIn++;
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 3");

            Console.WriteLine("What is the planet that is in the third position from sercanilla to the sun? --> ");
            Console.WriteLine("1 - Saturn");
            Console.WriteLine("2 - Venus");
            Console.WriteLine("3 - Earth");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D3)
            {
                preguntasC++;
            }
            else preguntasIn++;
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 4");

            Console.WriteLine("What planet do we live on? --> ");
            Console.WriteLine("1 - Neptune");
            Console.WriteLine("2 - Earth");
            Console.WriteLine("3 - Sun");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D2)
            {
                preguntasC++;
            }
            else preguntasIn++;
            Console.WriteLine("Please click on any character to continue with the next question");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 5");

            Console.WriteLine("Which planet is the largest in our system? --> ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Saturn");
            Console.WriteLine("3 - Jupiter");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D3)
            {
                preguntasC++;
            }
            else preguntasIn++;

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
}