using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitchingScript : MonoBehaviour
{
    public GameObject pistol1;
    public GameObject axe;

    public static int selectedWeapon = 1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedWeapon = 2;
        }

        if(selectedWeapon == 1)
        {
            pistol1.SetActive(true);
            axe.SetActive(false);
        }

        if (selectedWeapon == 2)
        {
            pistol1.SetActive(false);
            axe.SetActive(true);
        }
    }
}
