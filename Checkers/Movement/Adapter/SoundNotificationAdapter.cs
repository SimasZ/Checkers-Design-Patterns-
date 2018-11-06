using System;
using System.Media;

namespace Checkers.Movement.Adapter
{
    public class SoundNotificationAdapter : INotify
    {
        private SoundPlayer _soundPlayer = new SoundPlayer();

        public void Notify()
        {
            // Uncomment this when we find sound effect for checker move and
            // add .wav file location to SoundPlayer instance
            //soundPlayer.Play();
            Console.WriteLine("Notify Player using a sound effect");
        }
    }
}
