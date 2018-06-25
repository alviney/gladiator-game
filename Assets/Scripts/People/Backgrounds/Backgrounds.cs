using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Background", menuName = "Backgrounds")]
[System.Serializable]
public class Backgrounds: ScriptableObject {

	public List<Background> Stories;
	// public ListWrapper AllStories;
	public void AddStory() {

		Background background = new Background();
		Stories.Add(background);
		// AllStories.AddStory(background);
	}

	public List<Background> GetAllStories() {
		List<Background> temp = new List<Background>(Stories);
		return temp;
	}

}
// [System.Serializable]
// public class ListWrapper {
// 	public List<Background> stories;

// 	public void AddStory(Background background) {
// 		stories.Add(background);
// 	}

// 	public List<Background> GetStories() {
// 		return stories;
// 	}
// }
