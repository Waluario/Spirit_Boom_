﻿using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class videoControler : MonoBehaviour {
	
	public Renderer movieRenderer;
	public MovieTexture backgroundMovie;

	void Start () {

	//	transform.localScale = new Vector3(Camera.main.orthographicSize/2 * (Screen.width/Screen.height),Camera.main.orthographicSize/2,0f); 

		GetComponent<Renderer>().material.mainTexture = backgroundMovie;
		backgroundMovie.loop = true;
		backgroundMovie.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
