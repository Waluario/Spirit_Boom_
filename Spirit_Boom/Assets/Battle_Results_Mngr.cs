using UnityEngine;
using System.Collections;

public class Battle_Results_Mngr : MonoBehaviour {
	
	public int m_iExpGained;
	
	public UnityEngine.UI.Text
	m_xExpGained,
	m_xExpTotal;
	
	public float m_fTimeUntilNextState;
	
	void Start () {
		Player_Mngr.m_isExp = 987654321;
	}
	
	void Update () {
		if (m_iExpGained > 0 && m_fTimeUntilNextState <= 0.0f){
			int _iEG = (m_iExpGained % (m_iExpGained / 10 + 1)) + (m_iExpGained / 10 + 1);
			/*if (_i == 0){
				_i = 10;
			}*/
			
			m_iExpGained -= _iEG;
			Player_Mngr.m_isExp+= _iEG;
		}
		else if (m_iExpGained < 0){
			m_iExpGained = 0;
		}
		
		if (m_fTimeUntilNextState > 0.0f){
			m_fTimeUntilNextState -= Time.deltaTime;
		}
		
		m_xExpGained.text = "" + m_iExpGained;
		m_xExpTotal.text = "" + Player_Mngr.m_isExp;
	}
	
	public void Continue(){		
		if (m_iExpGained > 0 && m_fTimeUntilNextState <= 0.0f){
			Player_Mngr.m_isExp+= m_iExpGained;
			m_iExpGained = 0;
		}
		else if (m_fTimeUntilNextState > 0.0f){
			m_fTimeUntilNextState = 0.0f;
		}
		else if (m_iExpGained <= 0) {
			Application.LoadLevel("World");
		}
	}
}