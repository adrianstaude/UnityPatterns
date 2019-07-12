using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Trader : IHuman
    {
        public void Speak()
        {
            Debug.Log("Have Dis, need dat");
        }
    }
}

