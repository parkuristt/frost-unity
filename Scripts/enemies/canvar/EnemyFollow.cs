using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stoppingdistance;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    void FixedUpdate()
    {
        Debug.Log(speed);
        if (Vector2.Distance(transform.position, target.position) > stoppingdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        }
    }
}
