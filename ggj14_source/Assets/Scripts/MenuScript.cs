using UnityEngine;

public class MenuScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 100;
		const int buttonHeight = 30;
		
		GUI.skin = skin;
		
		if (GUI.Button(new Rect(620, 355, buttonWidth, buttonHeight), "Play")){
			Application.LoadLevel("ggj14_howToPlay"); 
		}

		if (GUI.Button(new Rect(620, 385, buttonWidth, buttonHeight), "Credits")){
			Application.LoadLevel("ggj14_scene2"); 
		}

		if (GUI.Button(new Rect(620, 415, buttonWidth, buttonHeight), "Exit")){
			Application.LoadLevel("ggj14_scene3_exitDead"); 
		}
	}
}