using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class NPCSpawner : MonoBehaviour
    {
        [SerializeField] NPCFactory factory;

        public void SpawnNPCAndSpeak(NPCenum type)
        {
            INPC npc = factory.GetNPC(type);
            npc.Speak();
        }
    }
}

