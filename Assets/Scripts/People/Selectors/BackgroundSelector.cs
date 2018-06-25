using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSelector : Selector {

	public List<Background> unusedStories;

	public List<Background> usedStories;
	public Backgrounds allStories;

	void Start() {
		unusedStories = allStories.GetAllStories();
	}

	public Background GetNewBackground() {
		return base.GetItem(unusedStories, usedStories);
	}
}
