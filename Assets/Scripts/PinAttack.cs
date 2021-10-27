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
			SpawnPin();
		}
		else {
			MovePin();
		}
	}
	public void SpawnPin() {
		pin.SetActive(true);
		transform.position= new Vector3(-20,Random.Range(-5, 3));
	}
	void MovePin() {
		transform.Translate(moveSpeed * Time.deltaTime, 0,0);
	}
}
