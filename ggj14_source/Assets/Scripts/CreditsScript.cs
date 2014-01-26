using UnityEngine;

public class CreditsScript : MonoBehaviour
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
		const int textWidth = 300;
		const int textHeight = 30;

		GUI.skin = skin;

		GUI.Label(new Rect(550, 285, textWidth, textHeight), "BrickStorm Games - Team");
		GUI.Label(new Rect(570, 315, textWidth, textHeight), "Code - Gregorio Benatti");
		GUI.Label(new Rect(570, 335, textWidth, textHeight), "Art - Rafael Santos");
		GUI.Label(new Rect(570, 355, textWidth, textHeight), "Design - BrickStorm + Regis");

		if (GUI.Button(new Rect(880, 497, buttonWidth, buttonHeight), "Back")){
			Application.LoadLevel("ggj14_menu"); 
		}
	}
}