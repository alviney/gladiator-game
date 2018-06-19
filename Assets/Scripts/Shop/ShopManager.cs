using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

	
#region Singleton

	public static ShopManager instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}

#endregion
}
