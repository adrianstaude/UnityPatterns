using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class AnimalFactory : AbstractFactory
    {

        public override IAnimal GetAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat:
                    IAnimal cat = new Cat();
                    return cat;
                case AnimalType.Dog:
                    IAnimal dog = new Dog();
                    return dog;
                default:
                    break;
            }
            return null;
        }

        public override IHuman GetHuman(HumanType type)
        {
            return null;
        }

    }
}

