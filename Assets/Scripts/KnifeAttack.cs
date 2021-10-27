using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
	public GameObject knife;
	[SerializeField] int dropSpeed;

	void Update()
    {
	    if (!knife.activeInHierarchy) {
			    SpawnKnife();
	    }
	    else {
			    MoveKnife();
	    }
    }
	public void SpawnKnife() {
		knife.SetActive(true);
		transform.position= new Vector3(Random.Range(-8, 9),0);
	}
	void MoveKnife() {
		transform.Translate(0,dropSpeed * Time.deltaTime, 0);
	}
}
