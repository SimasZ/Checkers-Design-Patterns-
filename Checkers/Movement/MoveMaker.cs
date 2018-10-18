using System;
using System.Media;

namespace Checkers.Movement
{
    public class MoveMaker
    {
        private readonly ICheckerMovementStrategy _checkerMovementStrategy;
        private readonly SoundPlayer _soundPlayer;

        public MoveMaker(ICheckerMovementStrategy checkerMovementStrategy)
        {
            _checkerMovementStrategy = checkerMovementStrategy;
            _soundPlayer = new SoundPlayer();
        }

        public void MakeMove(int x, int y)
        {
            Console.WriteLine("Making a move");
            _checkerMovementStrategy.Move(x, y);
        }

        public void PlaySound()
        {
            Console.WriteLine("Playing sound");
            _soundPlayer.Play();
        }
    }
}
