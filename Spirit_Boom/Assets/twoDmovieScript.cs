using UnityEngine;
using System.Collections;

public class twoDmovieScript : MonoBehaviour {

	public GUITexture BG;
	public MovieTexture movieBackground;

	// Use this for initialization
	void Start () {

		float newWidth = -(Screen.width-(Screen.height*(movieBackground.width/(float)movieBackground.height)));  
		float xOffset = (Screen.width - newWidth)/2;  
		BG.pixelInset = new Rect(xOffset, -Screen.height/2,newWidth,0);
		BG.texture = movieBackground;
		movieBackground.loop = true;
		movieBackground.Play ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
