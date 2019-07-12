using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class FactoryProducer : MonoBehaviour
    {
        public static AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.Human:
                    AbstractFactory humanFactory = new HumanFactory();
                    return humanFactory;
                case FactoryType.Animal:
                    AbstractFactory animalFactory = new AnimalFactory();
                    return animalFactory;
                default:
                    break;
            }
            return null;
        }
    }
}

