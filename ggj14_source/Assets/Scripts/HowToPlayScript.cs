using UnityEngine;

public class HowToPlayScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 200;
		const int buttonHeight = 30;
		
		GUI.skin = skin;
		
		if (GUI.Button(new Rect(800, 497, buttonWidth, buttonHeight), "Start Game")){
			Application.LoadLevel("ggj14_map"); 
		}
	}
}