using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] myObjects;
    public float spawnTime;
    public float spawnDelay;
    void Start()
    {
        InvokeRepeating("myObjects", 5f, 5f);
    }

    void Update()
    {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5, 5), 5, Random.Range(-5, 5));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

    }

}   