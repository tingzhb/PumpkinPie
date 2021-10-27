using UnityEngine;
using UnityEngine.UI;

public class PumpkinComplaints : MonoBehaviour {
	private Text complaint;
	private float timePassed;
	
	void Start()
	{
		complaint = GetComponent<Text>();
	}

	void Update() {
		timePassed += Time.deltaTime % 60;
		Debug.Log(timePassed);
		if (timePassed <= 5) {
			complaint.text = "I don't wana be pie!";
		}
		else if (timePassed <= 10) {
			complaint.text = "I don't like gravy!";
		}
		else if (timePassed <= 15) {
			complaint.text = "You make us into lattes?";
		}
		else if (timePassed <= 20) {
			complaint.text = "Is that cinnamon I smell?";
		}
		else if (timePassed <= 25) {
			complaint.text = "Carving? What's that?";
		}
		else if (timePassed <= 30) {
			complaint.text = "There's something warm inside...";
		}
		else if (timePassed <= 35) {
			complaint.text = "I'm on fire!";
		}
		else if (timePassed <= 40) {
			complaint.text = "HELP!";
		}
	}
}
