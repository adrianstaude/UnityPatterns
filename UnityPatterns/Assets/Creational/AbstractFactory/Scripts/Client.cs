using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Client : MonoBehaviour
    {

        [SerializeField] NPCSpawner spawner;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("1"))
            {
                spawner.SpawnHumans();
            }
            if (Input.GetKeyDown("2"))
            {
                spawner.SpawnAnimals();
            }
        }
    }
}

