using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsBoardUI : MonoBehaviour {

	public Transform tournamentsPanel;
	public List<Tournament> tournaments;
	public GameObject tournamentUIPrefab;
	private TournamentManager tournamentManager;

 	void Start() {
	 } 

	public void AddTournament(Tournament tournament) {
		tournaments.Add(tournament);
	}

	public void SetTournaments() {
		tournamentManager = (TournamentManager)FindObjectOfType(typeof(TournamentManager));  

		this.tournaments = tournamentManager.tournaments; 
	}

	public void CreateTournamentButtons() {

		SetTournaments();

		foreach(Tournament tournament in tournaments) {

			GameObject temp = Instantiate(tournamentUIPrefab, tournamentsPanel);

			temp.GetComponent<TournamentUI>().tournament = tournament;
		}
	}
}
