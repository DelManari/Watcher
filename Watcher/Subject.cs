using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
  public  class Subject:ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int value;
        
        public void SetValue(int cal)
            {
            value = cal;
            Notify();
            }
        public int getValue()
        {
            return value;
        }
        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }
}

