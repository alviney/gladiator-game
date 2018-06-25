using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelector : MonoBehaviour {

	public Background[] backgroundCollection;

	public Background GetNewBackground() {
		Background background = backgroundCollection[0];
		return background;
	}
}
