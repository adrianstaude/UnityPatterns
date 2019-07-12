using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class DebugClient : MonoBehaviour
    {

        [SerializeField] NPCSpawner spawner;

        private void Update()
        {
            if (Input.GetKeyDown("1"))
            {
                spawner.SpawnNPCAndSpeak(NPCenum.Beggar);
            }
            if (Input.GetKeyDown("2"))
            {
                spawner.SpawnNPCAndSpeak(NPCenum.Farmer);
            }
            if (Input.GetKeyDown("3"))
            {
                spawner.SpawnNPCAndSpeak(NPCenum.Trader);
            }
        }
    }
}

