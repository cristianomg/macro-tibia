using System.Threading;

namespace Screens
{
    public class Combo
    {
        public Combo()
        {
            FirstInterval = 1000;
            SecondInterval = 1000;
            Controller = false;
            Cancellation = new CancellationTokenSource();
        }
        public int FirstInterval { get; set; }
        public int SecondInterval { get; set; }
        public bool Controller { get; set; }
        public CancellationTokenSource Cancellation { get; private set; }
    }
}
