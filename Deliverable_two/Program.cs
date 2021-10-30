using System;

namespace Deliverable_two
{
    class Program
    {
        static void Main(string[] args)



         

        
        {

            string conversation = "Start";


            do
            {
                Console.WriteLine("How would you like to start this conversation?");
                string repeat = conversation;
                conversation = Console.ReadLine().ToLower();
                
                if (conversation == repeat)
                {
                    Console.WriteLine("I'm sorry, but you have already said that.");
                }
                else if (conversation == "hello")
                {
                    Console.WriteLine("Hello, good to see you");
                }
                else if (conversation == "sup")
                {
                    Console.WriteLine("I am good");
                }
                else if (conversation == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }
                else if (conversation == "bye")
                {
                    Console.WriteLine("Good bye!");
                }
                


            }
            while (conversation != "bye");





            




        }

    }
}
