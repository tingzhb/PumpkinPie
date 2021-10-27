using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject PUMPKIN;


    private void Awake() {
        Round1();
    }
    private void LateUpdate() {
        if (PUMPKIN.GetComponent<PumpkinWellbeing>().health <= 50) {
            Round2();
        }
    }
    void Round1() {
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
    }
    void Round2() {
        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
    }
}
