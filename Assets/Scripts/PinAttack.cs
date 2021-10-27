using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAttack : MonoBehaviour
{
	public GameObject pin;
	[SerializeField] int moveSpeed;

	void Update()
	{
		if (!pin.activeInHierarchy) {
			SpawnKnife();
		}
		else {
			MoveKnife();
		}
	}
	public void SpawnKnife() {
		pin.SetActive(true);
		transform.position= new Vector3(-9,Random.Range(-5, 6));
	}
	void MoveKnife() {
		transform.Translate(moveSpeed * Time.deltaTime, 0,0);
	}
}
