using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject DeathScreenUI;

    public GameObject Player1;

    void Update()
    {
        if(HealthBar.IsDead == true)
        {
            DeathScreenUI.SetActive(true);
        }

        if(HealthBar.IsDead == false)
        {
            DeathScreenUI.SetActive(false);
        }
    }


    public void Revive()
    {
        DeathScreenUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.IsGamePaused = false;
        HealthBar.IsDead = false;
        Player1.SetActive(true);
        HealthBar.health = HealthBar.maxHealth;
    }

    public  void LoadMenu()
    {
        Player1.SetActive(true);
        HealthBar.health = HealthBar.maxHealth;
        SceneManager.LoadScene(0);
        DeathScreenUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.IsGamePaused = false;
        HealthBar.IsDead = false;
    }
}
