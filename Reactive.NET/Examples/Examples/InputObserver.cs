using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class InputObserver : IObserver<string>
    {
        private bool completed = false;

        public void OnCompleted()
        {
            if (completed)
            {
                this.OnError(new Exception("The observer has already been completed"));                
            }
            else
            {
                completed = true;
                Console.WriteLine("In onCompleted");
            }
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("In onError; {0}", error.Message);
        }

        public void OnNext(string input)
        {
            if (completed)
            {
                this.OnError(new Exception("The observer has already been completed"));                
            }
            else
            {
                Console.WriteLine("The observer received the input: {0}", input);
            }            
        }
    }
}
