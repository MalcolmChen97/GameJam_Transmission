using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public int score = 0;
	public int transmissions=3;
	public Text scoreText;
	public Text transmissionsText;
	public Text LevelText;
	public int currentLevel;
	void Start () {
		LevelText.text = "Level" + currentLevel;
		Destroy (LevelText, 1f);
	}

	void Update () {
		updateUI ();
		
	}

	void updateUI(){
		scoreText.text = "Score: " + score;
		transmissionsText.text = "Transmissions: " + transmissions;
	}

	public void addscore(int haha){
		score += haha;
	}

	public void usetransmission(){
		transmissions--;
	}

	public void home(){
		SceneManager.LoadScene ("login");
	}

	public void nextLevel(){
		SceneManager.LoadScene ("Level"+(currentLevel+1));
	}

	public void restart(){
		score = 0;
		transmissions = 3;
	}
}
