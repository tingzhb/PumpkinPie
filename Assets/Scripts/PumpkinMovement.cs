using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMovement : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)]float moveSpeed = 10f;
    
    void Update() {
        MovePumpkin();
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp (pos.x, -8, 8);
        pos.y = Mathf.Clamp (pos.y, -5, 1);
        transform.position = pos;
    }
    void MovePumpkin() {
        transform.Translate(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"),0f);
    }
}
