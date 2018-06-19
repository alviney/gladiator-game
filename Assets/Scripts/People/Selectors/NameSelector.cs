﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSelector : MonoBehaviour {

	public List<string> unusedNames;

	public List<string> usedNames;

	#region Singleton
	public static NameSelector instance; 

	private void Awake() {
		if (instance != null) {
			return;
		}

		instance = this;
	}
	#endregion 

	private void Start() {
		// if load
			// create lists of 
		//else

	}

	public string GetName() {

		print("1");
		if (unusedNames.Count == 0) {
			print("2");
			ResetLists();
		}

		return RetrieveName();;
	}

	private void ResetLists() {

		foreach (string name in usedNames) {
			unusedNames.Add(name);
		}

		usedNames.Clear();
	}

	private string RetrieveName() {
		
		int index = Random.Range (0, unusedNames.Count);

		string name = unusedNames[index];

		unusedNames.RemoveAt(index);

		usedNames.Add(name);

		return name;
	}
}