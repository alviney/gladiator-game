using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleFactory : MonoBehaviour {

	public GameObject gladiatorPrefab;

	public GameObject racerPrefab;

	#region Singleton

		public static PeopleFactory instance;

		void Awake() {	
			if (instance != null) {
				return;
			}

			instance = this;
		}

	#endregion

	public GameObject CreateGladiator() {

		GameObject tempObj = Instantiate(gladiatorPrefab, this.transform);
		
		Gladiator gladiator = tempObj.GetComponent<Gladiator>();

		Background background = BackgroundSelector.instance.GetNewBackground();

		gladiator.Setup(background);

		return tempObj;

	}

	public GameObject CreateRacer() {

		GameObject tempObj = Instantiate(racerPrefab, this.transform);
		
		Racer racer = tempObj.GetComponent<Racer>();

		racer.Setup();

		return tempObj;
	}
}
