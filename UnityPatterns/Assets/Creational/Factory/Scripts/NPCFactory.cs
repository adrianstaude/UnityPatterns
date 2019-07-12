using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCFactory : MonoBehaviour
    {
        public INPC GetNPC(NPCenum type)
        {
            switch (type)
            {
                case NPCenum.Trader:
                    INPC trader = new NPCTrader();
                    return trader;
                case NPCenum.Farmer:
                    INPC farmer = new NPCFarmer();
                    return farmer;
                case NPCenum.Beggar:
                    INPC beggar = new NPCBeggar();
                    return beggar;
                default:
                    break;
            }
            return null;
        }
    }
}

