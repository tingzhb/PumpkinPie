using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text HealthText;
    public GameObject PUMPKIN;
    void Awake()
    {
        HealthText = GetComponent<Text>();
    }
    void Update() {
        HealthText.text = "Health: " + PUMPKIN.GetComponent<PumpkinWellbeing>().health;
    }
}
