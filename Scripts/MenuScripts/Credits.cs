using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public static bool IsCreditsOpen = false;

    public GameObject CreditsUI;

    public void pressed()
    {
        if (IsCreditsOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    public void Close()
    {
        CreditsUI.SetActive(false);
        IsCreditsOpen = false;
    }

    public void Open()
    {
        CreditsUI.SetActive(true);
        IsCreditsOpen = true;
    }
}
