using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class MyLuaFunctions : MonoBehaviour {
	
	void Start() {
		Lua.RegisterFunction("ToBattle", this, typeof(MyLuaFunctions).GetMethod("ToBattle"));
	}
	
	public void ToBattle() {
		Application.LoadLevel("Battle");
	}
	
	void Update(){
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}