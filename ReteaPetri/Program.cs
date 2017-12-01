using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeMachine coffeMachine = new CoffeMachine();
            Workers workers = new Workers();
            ProducerConsumer pc = new ProducerConsumer();
            string action = String.Empty;
            Console.WriteLine("Insert enything to use the machine and 'quit' to exit ");
            string choose = Console.ReadLine();
            while (!choose.Equals("quit"))
            {
                Console.WriteLine("Insert transition ");
                action = Console.ReadLine();
                if (pc.Execute(action) == true)
                {
                    if (action.Equals("C15") || action.Equals("C10"))
                    {
                        Console.WriteLine("Your coffe is ready!");
                    }
                    else
                    {
                        Console.WriteLine("Transition succefully done");
                    }
                }
                else
                {
                    Console.WriteLine("Operation failed");
                }
                Console.WriteLine("'quit' for exit\nEnything else for repeat");
                choose = Console.ReadLine();
            }
        }
    }
}

