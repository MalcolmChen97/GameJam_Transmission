﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public string leveltoload = "mainscene1";

	public void Play(){
		Debug.Log ("play");
		SceneManager.LoadScene (leveltoload);

	}
}
