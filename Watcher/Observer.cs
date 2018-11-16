using System.Windows.Forms;

namespace Watcher
{
    public class Observer:IObserver
    {
        private Subject sub;
        private int val ;

        public Observer(Subject name)
        {
            this.sub = name;
        }
        public void Update()
        {
            this.val = sub.getValue();
        }
        public int getVal()
        {
            return val;
        }
    }
}