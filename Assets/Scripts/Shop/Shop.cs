using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	PeopleManager peopleManager;
	PlayerManager playerManager;

	void Start() {
		peopleManager = PeopleManager.instance;
		playerManager = PlayerManager.instance;
	}

	public List<Gladiator> GetGladiators() {
		return peopleManager.GetGladiators(Location.Shop);
	}

	public void BuyGladiator(Gladiator gladiator) {

		peopleManager.SwapGladiatorLocations(gladiator, Location.Shop, Location.Player);

		playerManager.SetGold(-20);
		
	}
}


