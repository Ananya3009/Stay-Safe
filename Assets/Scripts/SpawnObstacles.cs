using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    public GameObject obstacles;
    public float maxX;
    public float maxY;  
    public float minX;
    public float minY;
    public float timeBtwSpawn;
    private float spawnTime;
    

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBtwSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacles,transform.position + new Vector3(randomX,randomY,0),transform.rotation);
    }
}