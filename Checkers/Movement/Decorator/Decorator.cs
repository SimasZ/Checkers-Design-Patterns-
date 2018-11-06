namespace Checkers.Movement.Decorator
{
    public class Decorator : IMoveScore
    {
        private IMoveScore _parent;

        public void SetParent(IMoveScore parent)
        {
            _parent = parent;
        }

        public virtual int GetScore()
        {
            if (_parent != null)
            {
                return _parent.GetScore();
            }

            return 0;
        }
    }
}
