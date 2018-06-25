using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGladiators : MonoBehaviour {

   	public List<Gladiator> GetGladiators() {
		return PeopleManager.instance.GetGladiators(Location.Player);
	}
}
