using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Woof");
        }
    }
}

