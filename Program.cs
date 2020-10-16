using System;


namespace BOGOL
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
          
            string[] writtenWords;
            int[] somearray = new int[5];
            string converterdistance;


            Console.WriteLine("Quit by writing quit");
            do //do while loop  (goes through the code  then checks status of while)
            {


                userInput = Console.ReadLine();
                writtenWords = userInput.Split(' '); //reads and splits the sentences

                for (int i = 0; i < writtenWords.Length; i++)
                {

                    if (writtenWords[0] == "set")
                    {
                        if (i == 0)
                        {

                            switch (writtenWords[1])
                            {
                                case "a":
                                    ;
                                    somearray[0] = Int32.Parse(writtenWords[3]);
                                    Console.WriteLine("value {0} set to {1}", writtenWords[1], writtenWords[3]);
                                    break;
                                case "b":

                                    somearray[1] = Int32.Parse(writtenWords[3]);
                                    Console.WriteLine("value {0} set to {1}", writtenWords[1], writtenWords[3]);
                                    break;
                                case "c":

                                    somearray[2] = Int32.Parse(writtenWords[3]);
                                    Console.WriteLine("value {0} set to {1}", writtenWords[1], writtenWords[3]);
                                    break;
                                case "d":

                                    somearray[3] = Int32.Parse(writtenWords[3]);
                                    Console.WriteLine("value {0} set to {1}", writtenWords[1], writtenWords[3]);
                                    break;

                                case "e":

                                    somearray[4] = Int32.Parse(writtenWords[3]);
                                    Console.WriteLine("value {0} set to {1}", writtenWords[1], writtenWords[3]);
                                    break;

                            }
                        }
                    }
                    else
                    {

                        if (writtenWords[1] != "quit")
                        {

                            if (i == 0)
                            {
                                Console.Write("Unnown comand: ");
                            }

                             // as long as the user dont write "quit"
                            

                                Console.Write(" {0} ", writtenWords[i]);

                            
                        }
                      
                    }
                }
                Console.WriteLine();



            } while (writtenWords[0] != "quit");
            Console.WriteLine("Goodbye");

        }
    }
}
