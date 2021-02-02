using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLooksCharacter : MonoBehaviour
{
    //[SerializeField]
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update() 
    {
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        if (angle > 0 && angle < 90 || angle > -270 && angle < -180)
        {
            if (transform.rotation != Quaternion.Euler(0, 180, 0))
                transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (angle > -180 && angle < 0)
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 0))
                transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
