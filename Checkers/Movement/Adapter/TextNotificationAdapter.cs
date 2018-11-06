using System;

namespace Checkers.Movement.Adapter
{
    public class TextNotificationAdapter : INotify
    {
        public void Notify()
        {
            Console.WriteLine("Notify Player using text");
        }
    }
}
