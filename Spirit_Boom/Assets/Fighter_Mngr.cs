﻿using UnityEngine;
using System.Collections;

public class Fighter_Mngr : MonoBehaviour {

	public Fighter_Player m_xFighter0;
	public Fighter_Enemy m_xFighter1;
	
	public Ability_Mngr
	m_xAbilityMngr;
	
	public int 
	m_iMenuChoice;
	
	public bool 
	m_bTurn,
	m_bHasMoved;
	
	public GameObject m_xPanel;

	// Use this for initialization
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
			Application.LoadLevel("World");
		}
		
		m_xPanel.SetActive(m_bTurn);
	}
	
	public void Fighter_Action(int p_i){
		if (m_bTurn && p_i < m_xAbilityMngr.m_xaAbilityList.Count && p_i >= 0){
			m_xFighter0.UseAbility(m_xAbilityMngr.Get_Ability(p_i));
			print ("AP Left: " + m_xFighter0.m_iAp + " / " + m_xFighter0.m_iMap);
			m_bHasMoved = true;
		}
		else if (m_bTurn && p_i == -1){
			Switch_Turn(false);
		}
		else if (!m_bTurn && p_i < m_xAbilityMngr.m_xaAbilityList.Count && p_i >= 0){
			m_xFighter1.UseAbility(m_xAbilityMngr.Get_Ability(p_i));
			print ("AP Left: " + m_xFighter1.m_iAp + " / " + m_xFighter1.m_iMap);
			m_bHasMoved = true;
		}
		else if (!m_bTurn && p_i == -1){
			Switch_Turn(true);
		}
	}
	
	/*public bool Menu_Action (Fighter_Base p_xUser, Fighter_Base p_xTarget){
		bool _b = false;
		
		if (Input.GetKeyDown("w")){
			m_iMenuChoice++;
			_b = true;
		}
		else if (Input.GetKeyDown("s")){
			m_iMenuChoice--;
			_b = true;
		}
		
		if (m_iMenuChoice >= p_xUser.m_xaAbilities.Count){
			m_iMenuChoice = 0;
		}
		
		if (m_iMenuChoice < 0){
			m_iMenuChoice = p_xUser.m_xaAbilities.Count - 1;
		}
		
		if (_b){
			print (m_iMenuChoice + " : " + p_xUser.m_xaAbilities[m_iMenuChoice].m_xName);
		}
		
		if (Input.GetKeyDown("d")){
			//p_xUser.UseAbility(m_iMenuChoice, p_xTarget);
			
			return true;
		}
		
		return false;
	}*/
	
	public void Switch_Turn(bool p_b){
		if (!p_b){
			print ("Player Turn End!");
			m_xFighter0.ApUp();
			
			//m_xFighter0.Set_Guard(!m_bHasMoved);
			m_xFighter1.On_Turn_Start();
		}
		else if (p_b){
			print ("Enemy Turn End!");
			m_xFighter1.ApUp();
			
			//m_xFighter1.Set_Guard(!m_bHasMoved);
			m_xFighter0.On_Turn_Start();
		}
		
		m_bTurn = p_b;
		m_bHasMoved = false;
	}
}