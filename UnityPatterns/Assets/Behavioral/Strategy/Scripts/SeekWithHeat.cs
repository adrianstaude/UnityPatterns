using UnityEngine;

namespace StrategyPattern
{
    public class SeekWithHeat : ISeekBehavior
    {
        public void Seek()
        {
            Debug.Log("Seeking with heat");
        }
    }
}
