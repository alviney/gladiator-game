using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator: Person {

	public Background background;
	public int armourModifier;
	public int weaponModifier;
	

	public void Setup(Background background) {
		this.background = background;
	}
	
}