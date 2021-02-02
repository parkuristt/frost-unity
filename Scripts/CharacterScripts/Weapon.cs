using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Weapon : MonoBehaviour {
	public Transform firePoint;

	public GameObject bulletPrefab;

    public int ammoMax;

    public Text ammoText;

    public bool IsReloading = false;

    private int ammoAmmount;
	
    void Start()
    {
        ammoAmmount = ammoMax;
    }
	void Update () {
        ammoText.text = ammoAmmount.ToString();
		if (Input.GetButtonDown("Fire1") && ammoAmmount > 0 && !IsReloading && !PauseMenu.IsGamePaused && WeaponSwitchingScript.selectedWeapon == 1)
        {
            FindObjectOfType<AudioManager>().Play("Shoot");
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            ammoAmmount -= 1;
        }
        if(Input.GetButtonDown("Fire1") && ammoAmmount == 0 || Input.GetKey(KeyCode.R) && !PauseMenu.IsGamePaused && WeaponSwitchingScript.selectedWeapon == 1)
        {
            StartCoroutine(MermiReloadSuresi());
        }
        IEnumerator MermiReloadSuresi()
        {
            if(!IsReloading && ammoAmmount != ammoMax && !PauseMenu.IsGamePaused)
            {
                IsReloading = true;
                FindObjectOfType<AudioManager>().Play("Reload");
                yield return new WaitForSeconds(1.1f);
                IsReloading = false;
                ammoAmmount = ammoMax;
            }

        }
	}
}
