using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyEventSystem : MonoBehaviour
{
    public Text TitleText;
    public Text DescriptionText;

    public int minSpawnTime;
    public int maxSpawnTime;


    [SerializeField]
    private float spawnRadius;

    public GameObject[] enemies;

    public string EventTitle;

    public string EventDescription;

    string EventDescription2;

    public int EnemyCount;

    public GameObject EventReporter;


    int EnemiesToSpawn = 0;

    void Start()
    {
        EventReporter.SetActive(false);
        StartCoroutine(WaitRandom());
    }

    IEnumerator WaitRandom()
    {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        EnemiesToSpawn = EnemyCount;
        SpawnEnemy();
        TitleText.text = EventTitle.ToString();
        EventDescription2 = EnemyCount + " " + EventDescription;
        DescriptionText.text = EventDescription2.ToString();
        EventReporter.SetActive(true);
        EnemyCount += 1;
        yield return new WaitForSeconds(3);
        EventReporter.SetActive(false);
        StartCoroutine(WaitRandom());
    }

    public void SpawnEnemy()
    {
        if (EnemiesToSpawn > 0)
        {
            Vector2 spawnPos = GameObject.Find("Player").transform.position;
            spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
            EnemiesToSpawn -= 1;
        }
    }
}
