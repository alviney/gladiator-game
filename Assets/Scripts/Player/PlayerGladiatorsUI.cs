using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGladiatorsUI : MonoBehaviour {
	public PlayerGladiators playerGladiators;
	public GameObject gladiatorViewPrefab;
	public Transform gladiatorViewParent;

	private List<Gladiator> gladiators;

	public void GetGladiators() {

		gladiators = playerGladiators.GetGladiators();

		ShowGladiatorViews();

	}

	private void ShowGladiatorViews() {

		foreach(Transform child in gladiatorViewParent) {
			Destroy(child.gameObject);
		}

		foreach(Gladiator gladiator in gladiators) {
			GameObject temp = Instantiate(gladiatorViewPrefab, gladiatorViewParent);
			temp.GetComponent<GladiatorView>().Init(gladiator);
		}
	}	
}
