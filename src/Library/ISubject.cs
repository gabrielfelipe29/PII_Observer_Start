namespace Observer;
using System;
using System.Collections.Generic;
public interface ISubject
{

    public List<IObserver> ObserverList { get; set; }


    public void AddToObserverList(IObserver observer);

    public void RemoveFromObserverList(IObserver observer);

    public void NotifyObservers();

}