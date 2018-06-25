using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

 [System.Serializable]
 public class GameData
 {
    public int score;
    public string name;
    public float timePlayed;
	public List<string> daList = new List<string>();
 
	public GameData(int scoreInt, string nameStr, float timePlayedF, List<string> daListF)
	{
		score = scoreInt;
		name = nameStr;
		timePlayed = timePlayedF;
		daList = daListF;
	}
 }

public class SavePrac : MonoBehaviour {

	List<string> hello = new List<string>();

	int currentScore = 0;
    string currentName = "Asd";
 	float currentTimePlayed = 5.0f;

 	public void SaveFile()
    {
		hello.Add("1");
		hello.Add("2");
		hello.Add("3");
		string destination = Application.persistentDataPath + "/save.dat";
		FileStream file;

		if(File.Exists(destination)) file = File.OpenWrite(destination);
		else file = File.Create(destination);

		GameData data = new GameData(currentScore, currentName, currentTimePlayed, hello);
		BinaryFormatter bf = new BinaryFormatter();
		bf.Serialize(file, data);
		file.Close();
     }
 
     public void LoadFile()
     {
		string destination = Application.persistentDataPath + "/save.dat";
		FileStream file;

		if(File.Exists(destination)) file = File.OpenRead(destination);
		else
		{
			Debug.LogError("File not found");
			return;
		}

		BinaryFormatter bf = new BinaryFormatter();
		GameData data = (GameData) bf.Deserialize(file);
		file.Close();

		currentScore = data.score;
		currentName = data.name;
		currentTimePlayed = data.timePlayed;
		foreach (string str in data.daList) {
			Debug.Log(str);
		} 

		print(data.name);
		Debug.Log(data.score);
		Debug.Log(data.timePlayed);
     }
}
