using UnityEngine;

namespace StrategyPattern
{
    public class SeekWithGPS : ISeekBehavior
    {
        public void Seek()
        {
            Debug.Log("Seeking with GPS");
        }
    }
}

