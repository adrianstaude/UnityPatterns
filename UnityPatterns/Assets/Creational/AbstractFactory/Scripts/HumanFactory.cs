using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class HumanFactory : AbstractFactory
    {

        public override IHuman GetHuman(HumanType type)
        {
            switch (type)
            {
                case HumanType.Beggar:
                    IHuman beggar = new Beggar();
                    return beggar;
                case HumanType.Farmer:
                    IHuman farmer = new Farmer();
                    return farmer;
                case HumanType.Trader:
                    IHuman trader = new Trader();
                    return trader;
                default:
                    break;
            }
            return null;
        }

        public override IAnimal GetAnimal(AnimalType type)
        {
            return null;
        }

    }
}


