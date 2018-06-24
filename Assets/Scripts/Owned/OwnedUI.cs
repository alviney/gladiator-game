using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnedUI : MonoBehaviour {

	new public Text name;
	public Text background; 
	public List<GameObject> gladiators;

	private int gladiatorIndex = 0;

	public void GetGladiators() {

		gladiators = OwnedManager.instance.GetGladiators();

		SetGladiator(gladiatorIndex);

	}

	public void SetGladiator(int index) {

		Gladiator glad = gladiators[index].GetComponent<Gladiator>();

		name.text = glad.name;

		background.text = glad.background.story;

	}	

}
