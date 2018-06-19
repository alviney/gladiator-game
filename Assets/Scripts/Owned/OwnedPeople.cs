using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedPeople : MonoBehaviour {

	public List<GameObject> gladiators;

	public void AddGladiator(GameObject gladiator) {

		gladiator.transform.SetParent(this.transform);

		gladiators.Add(gladiator);
	}
}
