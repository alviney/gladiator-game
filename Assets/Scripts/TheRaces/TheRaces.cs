using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRaces : MonoBehaviour {

	TheRacesPeople theRacesPeople;

	private void Start() {
		theRacesPeople = this.transform.GetComponent<TheRacesPeople>();
	}

	public GameObject[] GetRacers(int amount) {

		GameObject[] currentRacers = new GameObject[amount];

		currentRacers = theRacesPeople.GetNumberOfRacers(amount);

		return currentRacers;
	}
}
