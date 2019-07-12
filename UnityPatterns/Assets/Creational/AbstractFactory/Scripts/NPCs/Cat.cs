using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Cat : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Nian");
        }
    }
}

