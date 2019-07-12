using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Farmer : IHuman
    {
        public void Speak()
        {
            Debug.Log("Corn, corn, corn!");
        }
    }
}

