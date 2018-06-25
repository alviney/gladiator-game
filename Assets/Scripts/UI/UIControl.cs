﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

	public void ShowPanel(GameObject panelToShow) {
		panelToShow.SetActive(true);
	}

	public void HidePanel(GameObject panelToHide) {
		panelToHide.SetActive(false);
	}
}