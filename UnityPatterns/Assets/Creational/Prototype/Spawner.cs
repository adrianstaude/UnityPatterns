using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ICopyable copy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
        }
        if(Input.GetKeyDown("d"))
        {
            //sSpawnEnemy(Drone);
        }
    }

    public Enemy SpawnEnemy(Enemy prototype)
    {
        copy = prototype.Copy();
        return (Enemy)copy;
    }
}
