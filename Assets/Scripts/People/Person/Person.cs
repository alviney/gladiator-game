﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Person {

	public string name;

	public Location location;

	public Model model;

	// Setup Model
	public Person(string name) {
		this.name = name;
	}
}

