using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingScript : MonoBehaviour
{
    public float maxObjectHealth;
    public float objectHealth;
    public bool givesYouItem;

    void Start()
    {
        objectHealth = maxObjectHealth;
    }

    void Update(Collider2D collision)
    {
        if((collision.gameObject.tag == "tool") && (WeaponSwitchingScript.selectedWeapon == 2))
        {
            objectHealth -= 1;
            if (givesYouItem)
            {
                Player.wood += 1;
            }
        }
    }

    void Update()
    {
        if (objectHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
