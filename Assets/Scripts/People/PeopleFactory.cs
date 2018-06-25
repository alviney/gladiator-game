
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleFactory : MonoBehaviour {
	public static PeopleManager instance;
	private BackgroundSelector bs;
	private NameSelector ns;
	private ModelSelector ms;

	void Awake() {	
		bs = this.GetComponent<BackgroundSelector>();
		ns = this.GetComponent<NameSelector>();
		ms = this.GetComponent<ModelSelector>();
	}

	public Gladiator CreateGladiator() {

		Background background = bs.GetNewBackground();

		string name = ns.GetName();

		Gladiator newGladiator = new Gladiator(background, name);

		return newGladiator;

	}

	// public void CreateRacer(Location location) {

	// 	string name = ns.GetName();

	// 	Racer newRacer = new Racer(name, location);

	// 	return newRacer;
	// }
}
