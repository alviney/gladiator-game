using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Location { Shop, Tournament, Player}
public class PeopleManager : MonoBehaviour {
	public static PeopleManager instance;
	public PeopleFactory peopleFactory;

	private List<Gladiator> shopGladiators = new List<Gladiator>();
	private List<Gladiator> tournamentGladiators = new List<Gladiator>();
	private List<Gladiator> playerGladiators = new List<Gladiator>();

	#region Singleton
	void Awake() {	

			if (instance != null) {
				return;
			}

			instance = this;
	}
	#endregion

	public void CreateGladiator(Location location) {

		Gladiator gladiator = peopleFactory.CreateGladiator();

		AddGladiator(gladiator, location);
	}

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
}
