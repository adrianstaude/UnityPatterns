using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

    public Enemy Drone;
    public Enemy Tank;
    public Spawner spawner;

    private Enemy spawnedEnemy;
    private int droneCounter;
    private int tankCounter;


    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            spawnedEnemy = spawner.SpawnEnemy(Tank);
            spawnedEnemy.name = "Tank_Clone" + ++tankCounter;
            spawnedEnemy.transform.Translate(Vector3.forward * tankCounter);
        }
        if (Input.GetKeyDown("d"))
        {
            spawnedEnemy = spawner.SpawnEnemy(Drone);
            spawnedEnemy.name = "Drone_Clone" + ++droneCounter;
            spawnedEnemy.transform.Translate(Vector3.forward * droneCounter);
        }
    }
}
