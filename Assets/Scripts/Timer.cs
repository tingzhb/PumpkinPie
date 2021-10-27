using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private Text timerText;
	private float timePassed;
	private int minutesPassed;
	public GameObject PUMPKIN;

	
	void Start()
	{
		timerText = GetComponent<Text>();
	}

	void Update() {
		while (PUMPKIN.GetComponent<PumpkinWellbeing>().health > 0) {
			timePassed += Time.deltaTime;
			if (timePassed >= 60) {
				minutesPassed++;
				timePassed %= 60;
			}
			timerText.text = minutesPassed + "m " + timePassed.ToString("0.00") + "s";
		}
	}
}
