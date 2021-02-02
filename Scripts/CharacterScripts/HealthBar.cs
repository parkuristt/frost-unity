using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    Image bar;
    public static bool IsDead = false;
    public static float maxHealth = 100;
    public static float health;
    public Text healthText;
    public GameObject Player1;

    void Start()
    {

        bar = GetComponent<Image>();
        health = maxHealth;
    }
    void Update()
    {
        healthText.text = health.ToString();
        bar.fillAmount = health / maxHealth;
        if(health == 0 || health < 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Player1.transform.position = new Vector3(0, 0, 0);
        Player1.SetActive(false);
        IsDead = true;
    }
}
