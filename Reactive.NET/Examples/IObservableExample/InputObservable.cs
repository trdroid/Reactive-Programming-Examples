using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IObservableExample
{
    // An observable is a producer that produces data that any observers can subscribe to and consume.
    // This makes observers consumers of that data. 
    public class InputObservable : IObservable<string>, IDisposable
    {
        private readonly List<IObserver<string>> subscribers = new List<IObserver<string>>();

        private readonly CancellationTokenSource cancellationSource;
        private readonly CancellationToken cacellationToken;

        public InputObservable()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            throw new NotImplementedException();
        }
    }
}
