using UnityEngine;
using System.Collections;

public class MapStyleScript : MonoBehaviour {
	//public Texture backbroundGreen;
	//public Texture backbroundBrown;
	//public Texture backbroundYellow;

	//public GameObject mySprite;

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.W)){
			//renderer.material.(0, backbroundYellow);
			//mySprite.renderer.material.SetTexture(0, backbroundGreen);
		}
		if (Input.GetKeyDown(KeyCode.Q)){
			//mySprite. material.mainTexture=(0, backbroundYellow);
		}
		if (Input.GetKeyDown(KeyCode.E)){
			//mySprite.renderer.material.SetTexture(0, backbroundBrown);
		}
	}
}
