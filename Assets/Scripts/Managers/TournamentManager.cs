using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournamentManager : MonoBehaviour {

	public List<Tournament> tournaments;

	void Start() {

		Init("New");
	}

	private void Init(string setup) {

		tournaments = new List<Tournament>();

		Tournament tournament = new Tournament("Marvelli Arena", 6, 5);

		tournaments.Add(tournament);
	}


}
