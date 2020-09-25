using System;
using System.Collections.Generic;


namespace Observer
{
    interface IObservable
    {
        List <IObserver> Observers{get;}
        void Subscribe(IObserver observer);

        void Unsubscribe(IObserver observer);

        void Notificar();

    }

}
