using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCBeggar : INPC
    {
        public void Speak()
        {
            Debug.Log("Gimmeh Moneyyy");
        }
    }
}

