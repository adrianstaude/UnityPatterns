using UnityEngine;

namespace StrategyPattern
{
    public abstract class Missile : ScriptableObject
    {
        protected ISeekBehavior seekBehavior;

        public void ApplySeek()
        {
            seekBehavior.Seek();
        }

        public void SetSeekBehavior(ISeekBehavior seekType)
        {
            this.seekBehavior = seekType;
        }
    }
}

