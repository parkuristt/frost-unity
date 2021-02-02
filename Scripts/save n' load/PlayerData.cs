using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float health;
    public float[] position;
    public bool IsDead;

    public Color skinTone;
    public float rFloat;
    public float gFloat;
    public float bFloat;

    public float minSpawnTime;
    public float maxSpawnTime;
    public int EnemyCount;
    public int EnemiesToSpawn;

    public PlayerData (Player player)
    {
        IsDead = Player.IsDead;
        health = Player.health;

        rFloat = Player.rFloat;
        gFloat = Player.gFloat;
        bFloat = Player.bFloat;

        minSpawnTime = Player.minSpawnTime;
        maxSpawnTime = Player.maxSpawnTime;
        EnemyCount = Player.EnemyCount;
        EnemiesToSpawn = Player.EnemiesToSpawn;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
