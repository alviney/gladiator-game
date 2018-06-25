using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    [Tooltip("Choose which GameSettings asset to use")]
    public NewGameSettings _settings; 
    [SerializeField]
    public static NewGameSettings newGame; 
    public static Settings instance;
    void Awake(){

        // DontDestroyOnLoad(gameObject);

        if (Settings.instance==null){

            Settings.instance=this;

        } else {

            Debug.LogWarning("A previously awakened Settings MonoBehaviour exists!", gameObject);
        }
        if (Settings.newGame == null){

            Settings.newGame = _settings;
        }
    }
}
