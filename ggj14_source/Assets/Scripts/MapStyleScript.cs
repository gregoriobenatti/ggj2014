using UnityEngine;
using System.Collections;

public class MapStyleScript : MonoBehaviour {
	public SpriteRenderer renderer;
	public Sprite spriteGreen;
	public Sprite spriteYellow;
	public Sprite spriteBrown;


	void Start () {
	
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)){
			renderer = gameObject.GetComponent<SpriteRenderer>();
			renderer.sprite = spriteGreen;
		}

		if (Input.GetKeyDown(KeyCode.W)){
			renderer = gameObject.GetComponent<SpriteRenderer>();
			renderer.sprite = spriteYellow;
		}

		if (Input.GetKeyDown(KeyCode.E)){
			renderer = gameObject.GetComponent<SpriteRenderer>();
			renderer.sprite = spriteBrown;
		}
	}
}
