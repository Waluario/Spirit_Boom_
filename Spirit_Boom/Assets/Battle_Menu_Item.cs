﻿using UnityEngine;
using System.Collections;

public class Battle_Menu_Item : MonoBehaviour {

	public UnityEngine.UI.Text 
	m_xName,
	m_xDesc;
	
	public UnityEngine.UI.Button m_xButton;
	
	public Fighter_Mngr m_xFightMngr;
	
	public int m_iAbility;

	void Start () {
		
	}
	
	void Update () {
		m_xName.text = m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_xName;
		
		m_xDesc.text = m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_xDesc + 
			"\n Element: " + GetElement(m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_eEl) + 
				"\n Power: " + m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_iPow + 
				"\n Accuracy: " + m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_iHit + "%" + 
				"\n Cost: " + m_xFightMngr.m_xAbilityMngr.Get_Ability(m_iAbility).m_iCost;
				
	}
	
	public void Use_Ability(){
		m_xFightMngr.Fighter_Action(m_iAbility);
	}
	
	public string GetElement(e_Element p_e){
		switch(p_e){
		case e_Element.Fire:
			return "Fire";
		case e_Element.Water:
			return "Water";
		case e_Element.Earth:
			return "Earth";
		default:
			return "Neutral";
		}
	}
}