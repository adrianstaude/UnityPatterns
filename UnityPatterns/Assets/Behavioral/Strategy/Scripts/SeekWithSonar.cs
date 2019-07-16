using UnityEngine;

namespace StrategyPattern
{
    public class SeekWithSonar : ISeekBehavior
    {
        public void Seek()
        {
            Debug.Log("Seeking with sonar");
        }
    }
}
