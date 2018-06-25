using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GladiatorView : MonoBehaviour {

	new private Text name;

	public void Init(Gladiator gladiator) {

		name = transform.GetChild(0).GetComponent<Text>();

		name.text = gladiator.name;
	}
}
