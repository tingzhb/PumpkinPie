using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMovement : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)]float moveSpeed = 10f;
    
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0f,0f);
    }
}
