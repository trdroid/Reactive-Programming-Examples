using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            InputObserver inputObserver = new InputObserver();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("BYE"))
                {
                    System.Environment.Exit(0);
                }
                else if (input.Equals("END"))
                {
                    inputObserver.OnCompleted();

                    Console.WriteLine("The observer has been sent an onCompleted message ...");
                    Console.WriteLine("The observer cannot be sent any more messages ...");
                }
                else
                {
                    inputObserver.OnNext(input);
                }
            }
        }
    }
}