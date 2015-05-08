using UnityEngine;
using System.Collections;

public class cameraControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Camera.main.orthographicSize = 1920 * Screen.height / Screen.width * 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
