using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedManager : MonoBehaviour {

	private OwnedPeople ownedPeople;

#region Singleton

	public static OwnedManager instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}

#endregion

	void Start() {
		ownedPeople = this.transform.GetComponent<OwnedPeople>();
	}

	public List<GameObject> GetGladiators() {
		return ownedPeople.gladiators;
	}
	public void AddGladiator(GameObject gladiator) {
		ownedPeople.AddGladiator(gladiator);
	}
}
