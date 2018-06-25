using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRacesPeople : MonoBehaviour {

	public List<GameObject> racers;

	public int racerPoolSize;

	private void Start() {

		racers = new List<GameObject>();

		PopulatePool();
	}

	private void PopulatePool() {

		for (int i = 0; i < racerPoolSize; i++) {

			AddRacer();
		}
	}

	private void AddRacer() {
		
		// GameObject racer = PeopleFactory.instance.CreateRacer();

		// racer.transform.SetParent(this.transform);

		// racers.Add(racer);
	}

	private GameObject ChooseRandomRacer() {
		
		GameObject racer = new GameObject();

		//Choose Random Racer

		return racer;
	}

	public GameObject[] GetNumberOfRacers(int amount) {
		
		GameObject[] racers = new GameObject[amount];

		for (int i = 0; i < amount; i++) {
			racers[i] = ChooseRandomRacer();
		}

		return racers;
	}
}
