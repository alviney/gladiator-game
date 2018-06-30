using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TournamentUI : MonoBehaviour {

	public Tournament tournament;
	public Text tournamentName;

	void Start() {
		tournamentName.text = tournament.trackName;
	}

	public void LoadTournament() {
		GameManager.instance.LoadTournament(tournament);
	}
}
