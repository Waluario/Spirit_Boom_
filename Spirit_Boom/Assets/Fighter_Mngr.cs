using UnityEngine;
using System.Collections;

public class Fighter_Mngr : MonoBehaviour {

	public Fighter_Player m_xFighter0;
	public Fighter_Enemy m_xFighter1;
	
	public Ability_Mngr m_xAbilityMngr;
	public Battle_Results_Mngr m_xBRMngr;
	
	public GameObject m_xPanel;
	
	public Combat_Text_Mngr m_xCTMngr;
	
	public bool 
		m_bTurn,
		m_bHasMoved;
	
	void Start () {
		m_bTurn = Random.Range(0, 2) == 0 ? true : false;
	}
	
	void Update () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		
		if (!m_bTurn){
			Fighter_Action(m_xFighter1.Act());
		}
		
		if (m_xFighter0.m_iStatus == 1){
			Application.LoadLevel("Game_Over");
		}
		
		if (m_xFighter1.m_iStatus == 1){
			m_xPanel.SetActive(false);
			m_xBRMngr.gameObject.SetActive(true);
		}
		else {
			m_xPanel.SetActive(m_bTurn);
		}
	}
	
	public void Fighter_Action(int p_i){
		if (m_bTurn && p_i < m_xAbilityMngr.m_xaAbilityList.Count && p_i >= 0){
			m_xFighter0.UseAbility(m_xAbilityMngr.Get_Ability(p_i));
			m_bHasMoved = true;
		}
		else if (m_bTurn && p_i == -1){
			Switch_Turn(false);
		}
		else if (!m_bTurn && p_i < m_xAbilityMngr.m_xaAbilityList.Count && p_i >= 0){
			m_xFighter1.UseAbility(m_xAbilityMngr.Get_Ability(p_i));
			m_bHasMoved = true;
		}
		else if (!m_bTurn && p_i == -1){
			Switch_Turn(true);
		}
	}
	
	public void Switch_Turn(bool p_b){
		if (!p_b){
			print ("Player Turn End!");
			m_xFighter0.ApUp();
			m_xFighter1.On_Turn_Start();
		}
		else if (p_b){
			print ("Enemy Turn End!");
			m_xFighter1.ApUp();
			m_xFighter0.On_Turn_Start();
		}
		
		m_bTurn = p_b;
		m_bHasMoved = false;
	}
	
	public int Get_Player_Acc(int p_i){
		if (p_i < 0 || p_i > m_xAbilityMngr.m_xaAbilityList.Count){
			p_i = 0;
		}
		
		int _iAcc = m_xFighter0.m_iAcc + m_xFighter0.m_iHit + m_xAbilityMngr.m_xaAbilityList[p_i].m_iHit;
		
		if (_iAcc > 100){
			return 100;
		}
		else if (_iAcc < 0){
			return 0;
		}
		
		return _iAcc;
	}
}