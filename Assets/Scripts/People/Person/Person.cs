using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {

	new public string name;

	public Model model;

	// Setup Model
	private void Start() {
		name = NameSelector.instance.GetName();
	}

}

