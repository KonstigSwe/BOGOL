using System;

namespace BOGOL
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool online = true;
            Console.WriteLine("Quit by writing quit");
            while (online == true)
            {


                userInput = Console.ReadLine();
                if (userInput != "quit")  // as long as the user dont write "quit"
                {
                    Console.WriteLine("command: {0}", userInput);
                    Console.WriteLine();
                }
                if (userInput == "quit")  // Turns of pogram
                {
                    online = false;
                    Console.WriteLine("Good Bye");
                }
            }


        }
    }
}
