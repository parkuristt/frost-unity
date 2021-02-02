using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float health;
    public static bool IsDead;

    public static float rFloat;
    public static float gFloat;
    public static float bFloat;

    public static float minSpawnTime = 10;
    public static float maxSpawnTime = 25;
    public static int EnemyCount = 2;
    public static int EnemiesToSpawn;

    public static int wood;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
}
