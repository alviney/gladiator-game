using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBank : MonoBehaviour {

	public int gold = 200;

#region Singleton

	public static PlayerBank instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}

#endregion
	
	public int GetGold() {
		return gold;
	} 

	public void SetGold(int incoming) {
		gold += incoming;
	}
}


