using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	private DataController dataController;
	void Awake() {

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);

		dataController = this.GetComponent<DataController>();
	}

	public void NewGame() {
		dataController.NewGame();
		SceneManager.LoadScene("Main");
	}
	public void ContinueGame() {
		SceneManager.LoadScene("Main");
	}

	public void LoadTournament(Tournament tournament) {
		dataController.SaveGameData();
		SceneManager.LoadScene("Racing");
	}


}
