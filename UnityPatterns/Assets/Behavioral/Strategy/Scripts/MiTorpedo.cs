using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class MiTorpedo : Missile
    {
        private void Awake()
        {
            this.seekBehavior = new SeekWithSonar();
        }
    }
}

