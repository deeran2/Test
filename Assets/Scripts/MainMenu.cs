﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GUISkin skin;


	void OnGUI(){

		GUI.skin = skin;

		GUI.Label (new Rect (Screen.width/2 - 150, Screen.height/2 - 80, 400, 80), "Square Game");

		if (PlayerPrefs.GetInt ("Level Complete") > 0) {
			if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2 + 10, 100, 45), "Continue")) {
				SceneManager.LoadScene ("LevelSelect");
			}
		}
		if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2  + 65, 100, 45), "New Game")){
			PlayerPrefs.SetInt ("Level Complete", 1);
			PlayerPrefs.SetInt ("Level1stars", 0);
			PlayerPrefs.SetInt ("Level2stars", 0);
			PlayerPrefs.SetInt ("Level3stars", 0);

			SceneManager.LoadScene ("LevelSelect");
		} 	
		if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2  + 120, 100, 45), "Quit")){

			Application.Quit (); 
		}
	}
}
