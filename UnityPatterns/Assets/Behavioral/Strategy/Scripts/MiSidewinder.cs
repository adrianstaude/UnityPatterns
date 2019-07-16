using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class MiSidewinder : Missile
    {
        private void Awake()
        {
            this.seekBehavior = new SeekWithHeat();
        }
    }
}

