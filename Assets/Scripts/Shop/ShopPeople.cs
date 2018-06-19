using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPeople : MonoBehaviour {

	public List<GameObject> gladiators;

	public int numberOfGladiatorsForSale;

	private void Start() {

		gladiators = new List<GameObject>();

		PopulateShop();
	}

	private void PopulateShop() {

		for (int i = 0; i < numberOfGladiatorsForSale; i++) {

			AddGladiator();
		}
	}

	public void AddGladiator() {
		
		GameObject gladiator = PeopleFactory.instance.CreateGladiator();

		gladiator.transform.SetParent(this.transform);

		gladiators.Add(gladiator);
	}
}
