using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
	public GameObject Knife;

	void Update()
    {
	    if (!Knife.activeInHierarchy) {
		    if (Random.Range(1, 1001) > 999) {
			    SpawnKnife();
		    }
	    }
	    else {
			    MoveKnife();
	    }
    }
	public void SpawnKnife() {
		Knife.SetActive(true);
	}
	void MoveKnife() {
		transform.Translate(0,-2 * Time.deltaTime, 0);
	}
}
