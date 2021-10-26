using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeDestroy : MonoBehaviour {
	public GameObject knife;
	private void OnCollisionEnter2D(Collision2D collision) {
		if (knife.activeInHierarchy) {
			Destroy(knife.gameObject);
		}
	}
}
