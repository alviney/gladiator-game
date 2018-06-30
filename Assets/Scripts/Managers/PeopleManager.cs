using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Location { Shop, Tournament, Player}

public class PeopleManager : MonoBehaviour {
	public static PeopleManager instance;
	public PeopleFactory peopleFactory;

	private DataController dataController;
	public List<Gladiator> shopGladiators = new List<Gladiator>();
	private List<Gladiator> tournamentGladiators = new List<Gladiator>();
	private List<Gladiator> playerGladiators = new List<Gladiator>();
	private enum Setup { New, Load }

	#region Singleton
	void Awake() {	

			if (instance != null) {
				return;
			}

			instance = this;
	}
	#endregion

	void Start() {

		dataController = (DataController)FindObjectOfType(typeof(DataController));  

		if (!dataController.newGame) {
			Init("Load");

		} else {

			Init("New");
		}

	}
	public void CreateGladiator(Location location) {

		Gladiator gladiator = peopleFactory.CreateGladiator();

		AddGladiator(gladiator, location);
	}

	// public void PrintJson() {
	// 	ListContainer container = new ListContainer(shopGladiators);
	// 	print(JsonUtility.ToJson(container));
	// }

	// public void CreateRacer(Location location) {

	// 	string name = ns.GetName();

	// 	Racer newRacer = new Racer(name, location);

	// 	return newRacer;
	// }

	public void SwapGladiatorLocations(Gladiator gladiator, Location from, Location to) {
		RemoveGladiator(gladiator, from);
		AddGladiator(gladiator, to);
	}
	public void AddGladiator(Gladiator gladiator, Location location) {
		gladiator.location = location;
		GetListFromLocation(location).Add(gladiator);
	}

	public void RemoveGladiator(Gladiator gladiator, Location location) {
		GetListFromLocation(location).Remove(gladiator);
	}

	public List<Gladiator> GetGladiators(Location location) {
		return GetListFromLocation(location);
	}

	private List<Gladiator> GetListFromLocation(Location location) {
		switch (location) {
			case Location.Shop:
				return shopGladiators;
			case Location.Tournament:
				return tournamentGladiators;
			case Location.Player:
				return playerGladiators;
		}
		return null;
	}

	private void Init(string setup) {

		if (setup == "New") {
			for (int i = 0; i < Settings.newGame.numOfGladsInShop; i++)
			{
				CreateGladiator(Location.Shop);
			}

			dataController.SaveGameData();
		} else {
			shopGladiators = dataController.gameData.shopGladiators;

			tournamentGladiators = dataController.gameData.tournamentGladiators;

			playerGladiators = dataController.gameData.playerGladiators;
		}	 
	}
}
