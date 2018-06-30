using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour {

	public void ShowPanel(GameObject panelToShow) {
		panelToShow.SetActive(true);
	}

	public void HidePanel(GameObject panelToHide) {
		panelToHide.SetActive(false);
	}
}
