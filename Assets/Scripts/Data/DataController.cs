using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// This should be placed in menu so that it is called before game instance is loaded ****

public class DataController : MonoBehaviour {

	public GameData gameData;
	public bool newGame = false;
	private string gameDataFileName = "data.json";
	private string gameDataProjectFilePath = "/StreamingAssets/data.json";

	
	void Awake() {
		LoadGameData();
	}

	public void LoadGameData() {
		string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

		if (File.Exists (filePath)) {
			string dataAsJson = File.ReadAllText(filePath);

			gameData = JsonUtility.FromJson<GameData>(dataAsJson);

		} 
	}

	public void SaveGameData()
    {
		// Things to save
		gameData.shopGladiators = PeopleManager.instance.GetGladiators(Location.Shop);
		gameData.tournamentGladiators = PeopleManager.instance.GetGladiators(Location.Tournament);
		gameData.playerGladiators = PeopleManager.instance.GetGladiators(Location.Player);
		//

        string dataAsJson = JsonUtility.ToJson (gameData);

        string filePath = Application.dataPath + gameDataProjectFilePath;
        File.WriteAllText (filePath, dataAsJson);

    }

	public void NewGame() {
		newGame = true;
		gameData = new GameData();
	}
}
