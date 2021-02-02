using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator Animations;
    public float Bullet;
    void Start()
    {
        Bullet = 0;
        Animations.SetBool("IsWalking", true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Bullet ++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Animasyon());
        }   
    }
    void Update()
    {
        if(Bullet >= 5)
        {
            Bullet = 0;
            Destroy(gameObject);
        }
    }

    IEnumerator Animasyon()
    {
        Animations.SetBool("IsWalking", false);
        Animations.SetBool("IsSlapping", true);
        yield return new WaitForSeconds(0.7f);
        Animations.SetBool("IsSlapping", false);
        Animations.SetBool("IsWalking", true);
    }
}
