using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedManager : MonoBehaviour {

#region Singleton

	public static OwnedManager instance;

	void Awake() {	
		if (instance != null) {
			return;
		}

		instance = this;
	}

#endregion
}
