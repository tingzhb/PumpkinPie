using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject PUMPKIN;


    private void Awake() {
        Round1();
    }
    private void LateUpdate() {
        if (PUMPKIN.GetComponent<PumpkinWellbeing>().health <= 100 && PUMPKIN.GetComponent<PumpkinWellbeing>().health > 50) {
            Round2();
        }
        else if (PUMPKIN.GetComponent<PumpkinWellbeing>().health <= 50) {
            Round3();
        }
    }
    void Round1() {
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
    }
    void Round2() {
        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
    }
    void Round3() {
        Enemy1.SetActive(true);
        Enemy2.SetActive(true);
        Enemy3.SetActive(true);
        Enemy4.SetActive(true);
    }
}
