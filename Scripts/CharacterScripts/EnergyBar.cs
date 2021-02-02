using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyBar : MonoBehaviour
{
    Image eBar2;
    public static float energy = 100f;
    public static int displayedEnergy;
    public Text energyText;
    void Start()
    {
        eBar2 = GetComponent<Image>();
        energy = 100f;
    }

    void Update()
    {
        displayedEnergy = Mathf.RoundToInt(energy);
        energyText.text = displayedEnergy.ToString();
        eBar2.fillAmount = energy / 100;
    }
}
