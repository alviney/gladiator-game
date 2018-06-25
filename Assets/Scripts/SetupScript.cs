using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupScript : MonoBehaviour {

	void Start () {
		for (int i = 0; i < 5; i++)
		{
			PeopleManager.instance.CreateGladiator(Location.Shop);
		}
	}
	
}
