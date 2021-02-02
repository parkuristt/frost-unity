using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    public int spawnAtStart;
    public int spawnAfterStart;
    public float waitingTimeAfterSpawn;
    private int howMuchToSpawnRn = 0;

    public float maxY;
    public float minY;

    public float maxX;
    public float minX;

    void Start()
    {
        howMuchToSpawnRn = spawnAtStart;
        StartCoroutine(wait());
    }

    void Update()
    {
        if (howMuchToSpawnRn >= 0)
        {
            spawnObject();
            howMuchToSpawnRn -= 1;
        }
    }

    public void spawnObject()
    {
        Vector2 spawnPos = (new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)));
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], spawnPos, Quaternion.identity);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitingTimeAfterSpawn);
        howMuchToSpawnRn = spawnAfterStart;
        StartCoroutine(wait());
    }
}
