using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject characterMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }





    private void Start()
    {
        characterMenu.SetActive(false);
    }
}