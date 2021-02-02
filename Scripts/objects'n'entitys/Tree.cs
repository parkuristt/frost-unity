using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject treeGenerator;

    void Start()
    {
        treeGenerator = "treeGenerator";
    }

    void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Tree1" || collision.gameObject.name == "Tree1")
        {
            treeGenerator.GetComponent<SpawnObject>();
            Destroy(gameObject);
        }
    }
}
    