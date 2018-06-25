using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector: MonoBehaviour {


	public virtual T GetItem<T>(List<T> unusedList, List<T> usedList) {

		if (unusedList.Count == 0) {
			ResetLists(unusedList, usedList);
		}

		return RetrieveItem(unusedList, usedList);;
	}

	private void ResetLists<T>(List<T> unusedList, List<T> usedList) {

		foreach (T item in usedList) {
			unusedList.Add(item);
		}

		unusedList.Clear();
	}

	private T RetrieveItem<T>(List<T> unusedList, List<T> usedList) {
		
		int index = Random.Range (0, unusedList.Count);

		T item = unusedList[index];

		unusedList.RemoveAt(index);

		usedList.Add(item);

		return item;
	}
}
