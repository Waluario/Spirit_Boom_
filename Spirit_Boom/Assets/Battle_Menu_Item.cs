using UnityEngine;
using System.Collections;

public class Battle_Menu_Item : MonoBehaviour {

	public UnityEngine.UI.Text 
	m_xName,
	m_xDesc;
	
	public UnityEngine.UI.Button m_xButton;
	
	public Fighter_Mngr m_xFightMngr;
	
	public Ability_Mngr m_xAbilityMngr;
	
	public Battle_Menu_Mngr m_xBMMngr;
	
	public int m_iAbility;
	
	public GameObject m_xPanel;
	
	public bool m_bOnlyonce;
	
	void Start () {
		m_bOnlyonce = false;
	}
	
	void Update () {
		if (!m_bOnlyonce){
			m_xBMMngr = GetComponentInParent<Battle_Menu_Mngr>();
			m_xFightMngr = m_xBMMngr.m_xFmngr;
			m_xAbilityMngr = m_xBMMngr.m_xAmngr;
			
			m_xName.text = m_xAbilityMngr.Get_Ability(m_iAbility).m_xName;
			
			m_bOnlyonce = true;
		}
		
		m_xDesc.text = m_xAbilityMngr.Get_Ability(m_iAbility).m_xDesc + 
			"\n Element: " + GetElement(m_xAbilityMngr.Get_Ability(m_iAbility).m_eEl) + 
				"\n Power: " + m_xAbilityMngr.Get_Ability(m_iAbility).m_iPow + 
				"\n Accuracy: " + m_xFightMngr.Get_Player_Acc(m_iAbility) + "%" + 
				"\n Cost: " + m_xAbilityMngr.Get_Ability(m_iAbility).m_iCost;
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