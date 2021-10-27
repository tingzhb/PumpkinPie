using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinWellbeing : MonoBehaviour {
	[SerializeField] public int health;
	[SerializeField] int maxHealth;
	public GameObject ouch;
	private void Awake() {
		health = maxHealth;
	}
	void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}
	void OnTriggerEnter2D(Collider2D other) {
		TakeDamage(10);
	}
}
