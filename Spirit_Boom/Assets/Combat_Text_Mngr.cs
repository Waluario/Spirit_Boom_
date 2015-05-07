using UnityEngine;
using System.Collections;

public class Combat_Text_Mngr : MonoBehaviour {
	
	UnityEngine.UI.Text m_xText;
	
	void Start () {
		m_xText = GetComponentInChildren<UnityEngine.UI.Text>();
	}
	
	public void Add_Text(string p_x){
		m_xText.text += ("\n" + p_x);
	}
	
	public void Set_Text(string p_x){
		m_xText.text = p_x;
	}
	
	public void Clear_Text(){
		m_xText.text = "";
	}
}