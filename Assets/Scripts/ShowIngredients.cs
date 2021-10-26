using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowIngredients : MonoBehaviour {
	public GameObject IngredientsList;
	public Button ingredientsButton;
	private void Start() {
		Button btn = ingredientsButton.GetComponentInParent<Button>();
		btn.onClick.AddListener(Show);
	}
	void Show() {
		IngredientsList.SetActive(true);
	}
}
