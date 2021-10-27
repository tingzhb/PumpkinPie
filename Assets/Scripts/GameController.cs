using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Enemy1;
    public GameObject Enemy2;

    private void Update() {
        Enemy1.SetActive(true);
    }
}
