using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator: Person {

	public Background background;
	public int armourModifier;
	public int weaponModifier;
	

	public Gladiator(Background background, string name) : base(name) {
		this.background = background;
	}
	
}