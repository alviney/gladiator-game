using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour {
	
	public Shop shop;
	new public Text name;
	public Text background; 
	public List<Gladiator> gladiators;

	private int gladiatorIndex = 0;

	public void GetGladiators() {

		gladiators = shop.GetGladiators();

		SetGladiator(gladiatorIndex);

	}

	public void SetGladiator(int index) {

		Gladiator glad = gladiators[index];

		name.text = glad.name;

		background.text = glad.background.story;

	}	

	public void NextGladiator() {

		gladiatorIndex++;

		if (gladiatorIndex >= gladiators.Count)
			gladiatorIndex = 0;

		SetGladiator(gladiatorIndex);
	}

	public void PreviousGladiator() {
		
		gladiatorIndex--;

		if (gladiatorIndex <= 0)
			gladiatorIndex = gladiators.Count - 1;

		SetGladiator(gladiatorIndex);
	}

	public void RefreshGladiator() {
		SetGladiator(gladiatorIndex);
	}

	public void BuyGladiator() {

		shop.BuyGladiator(gladiators[gladiatorIndex]);

		RefreshGladiator();
	}
}

