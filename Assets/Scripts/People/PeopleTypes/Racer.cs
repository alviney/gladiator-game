using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : Person {

	public int racesRun;
	public int racesWon;

	public Racer(string name) : base (name) {
		racesWon = 0;
		racesRun = 0;
	}
}
