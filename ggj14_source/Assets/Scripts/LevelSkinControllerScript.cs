using UnityEngine;
using System.Collections;

public class LevelSkinControllerScript : MonoBehaviour {
	public SpriteRenderer renderer;
	public Sprite s1;
	public Sprite s2;

	void Start () {
	
	}
	
	void FixedUpdate () {
	
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.W)){
		renderer = gameObject.GetComponent<SpriteRenderer>();
		renderer.sprite = s1;
		}

		if (Input.GetKeyDown(KeyCode.Q)){
			renderer = gameObject.GetComponent<SpriteRenderer>();
			renderer.sprite = s2;
		}




	}
}
