using UnityEngine;

public class TryAgainScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 130;
		const int buttonHeight = 30;
		
		GUI.skin = skin;
	
		if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), 510, buttonWidth, buttonHeight), "Try Again")){
			Application.LoadLevel("ggj14_menu"); 
		}
	}
}