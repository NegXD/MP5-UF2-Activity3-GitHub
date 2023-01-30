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
                case ConsoleKey.D4:
                    SistemaSolar();
                    break;
                case ConsoleKey.D5:
                    NameOfTheCapitals(();
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
        Console.WriteLine("4 - Questions about solar system");
        Console.WriteLine("5 - Name of the capitals");
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
    
    public string void NameOfTheCapitals()
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
                preguntasC++;
            }
            else
            {
                preguntasIn++;
                Console.WriteLine("The correct answer is 2 - Moscu");
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

   
}