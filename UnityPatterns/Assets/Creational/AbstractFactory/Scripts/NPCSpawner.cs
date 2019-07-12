using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class NPCSpawner : MonoBehaviour
    {
        private AbstractFactory abstractFactory;

        public void SpawnHumans()
        {
            abstractFactory = FactoryProducer.GetFactory(FactoryType.Human);

            IHuman beggar;
            IHuman farmer;
            IHuman trader;

            beggar = abstractFactory.GetHuman(HumanType.Beggar);
            farmer = abstractFactory.GetHuman(HumanType.Farmer);
            trader = abstractFactory.GetHuman(HumanType.Trader);

            beggar.Speak();
            farmer.Speak();
            trader.Speak();
        }

        public void SpawnAnimals()
        {
            abstractFactory = FactoryProducer.GetFactory(FactoryType.Animal);

            IAnimal cat;
            IAnimal dog;

            cat = abstractFactory.GetAnimal(AnimalType.Cat);
            dog = abstractFactory.GetAnimal(AnimalType.Dog);

            cat.Voice();
            dog.Voice();
        }
    }
}

