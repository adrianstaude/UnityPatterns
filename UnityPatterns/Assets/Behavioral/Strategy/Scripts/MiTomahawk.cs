using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class MiTomahawk : Missile
    {
        private void Awake()
        {
            this.seekBehavior = new SeekWithGPS();
        }
    }
}

