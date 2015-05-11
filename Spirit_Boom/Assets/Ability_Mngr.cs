using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ability_Mngr : MonoBehaviour {
	
	public List<Ability_Base> m_xaAbilityList;
	
	public Combat_Text_Mngr m_xCTMngr;
	
	public Ability_Effects_Mngr m_xAEMngr;
	
	public Ability_Base Get_Ability(int p_i){
		return m_xaAbilityList[p_i];
	}
}