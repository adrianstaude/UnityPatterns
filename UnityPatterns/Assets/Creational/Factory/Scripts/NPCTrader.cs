using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCTrader : INPC
    {
        public void Speak()
        {
            Debug.Log("I have dis and dat, wanna buy?");
        }
    }
}

