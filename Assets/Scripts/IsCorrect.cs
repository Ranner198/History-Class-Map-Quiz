using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IsCorrect : MonoBehaviour {

	public Dropdown[] DP;
	public int[] menuIndex;
	public int Checker = 0;
	//public Responses[] RP;

	void Start () {		
		for (int i = 0; i < DP.Length; i++) {
			menuIndex[i] = DP[i].GetComponent<Dropdown> ().value;
			//print (menuIndex[i]);
			Checker = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void GetButton(){

		Checker = 0;

		for (int i = 0; i < DP.Length; i++) 
		{
			menuIndex[i] = DP[i].GetComponent<Dropdown> ().value;
			if (menuIndex [i] == i + 1)
			{
				DP [i].image.color = Color.green;
				DP [i].enabled = false;
				Checker++;
			} 
			else 
			{
				DP [i].image.color = Color.red;
			}				
		}
	}

	void OnGUI()
	{
		if (Checker == DP.Length) {
			if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.5f, Screen.width / 4, Screen.height / 4), "Great Job See You At The Test! \n\n   Click here to start again!"))
			{
				Application.LoadLevel (Application.loadedLevel);
				//print("clicked");
			}
		}
	}
}
