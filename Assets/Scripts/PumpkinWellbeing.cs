using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinWellbeing : MonoBehaviour {
	[SerializeField] int health;
	[SerializeField] int maxHealth;
	private void Awake() {
		health = maxHealth;
	}
	void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}
	void OnTriggerEnter2D(Collider2D other) {
		TakeDamage(10);
		Debug.Log("Ouch!");
	}
    // Start is called before the first frame update

}
