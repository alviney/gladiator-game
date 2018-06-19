using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRacesManager : MonoBehaviour {

	TheRacesPeople theRacesPeople;

	#region Singleton

		public static TheRacesManager instance;

		void Awake() {	
			if (instance != null) {
				return;
			}

			instance = this;
		}

	#endregion

	private void Start() {
		theRacesPeople = this.transform.GetComponent<TheRacesPeople>();
	}

	public GameObject[] GetRacers(int amount) {

		GameObject[] currentRacers = new GameObject[amount];

		currentRacers = theRacesPeople.GetNumberOfRacers(amount);

		return currentRacers;
	}
}
