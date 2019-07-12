using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Beggar : IHuman
    {
        public void Speak()
        {
            Debug.Log("Gimme M0ney");
        }
    }
}

