using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelector : MonoBehaviour {

#region  Singleton

	public static BackgroundSelector instance;

	void Awake () {

		if (instance != null) {
			return;
		}
		instance = this;

	}
#endregion

	public Background[] backgroundCollection;

	public Background GetNewBackground() {
		Background background = backgroundCollection[0];
		return background;
	}
}
