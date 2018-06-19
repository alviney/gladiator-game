using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

	private ShopPeople shopPeople;

#region Singleton

	public static ShopManager instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}
#endregion

	void Start() {
		shopPeople = this.transform.GetComponent<ShopPeople>();
	}

	public List<GameObject> GetGladiators() {
		return shopPeople.gladiators;
	}

	public void BuyGladiator(int index) {

		GameObject gladiator = shopPeople.GetGladiatorFromShop(index);

		OwnedManager.instance.AddGladiator(gladiator);

		PlayerBank.instance.SetGold(-20);

		shopPeople.RemoveGladiator(index);
	}
}


