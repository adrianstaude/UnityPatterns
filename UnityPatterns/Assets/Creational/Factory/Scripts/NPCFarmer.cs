using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCFarmer : INPC
    {
        public void Speak()
        {
            Debug.Log("Corn, Corn, Corn!");
        }
    }
}

