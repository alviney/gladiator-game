using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	
#region Singleton

	public static PlayerManager instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}
#endregion

	public int gold = 200;
	
	public int GetGold() {
		return gold;
	} 

	public void SetGold(int incoming) {
		gold += incoming;
	}
	
}
