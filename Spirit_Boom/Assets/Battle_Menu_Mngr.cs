using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Battle_Menu_Mngr : MonoBehaviour {
	
	public Ability_Mngr m_xAmngr;
	
	public Fighter_Mngr m_xFmngr;
	
	public Fighter_Player m_xPlayer;
	
	public GameObject 
		m_xOriginal,
		m_xEndturnbutton;
	
	public Battle_Menu_Item[] m_xaBattleMenuItems;
	
	public float
		m_fXa,
		m_fYaa,
		m_fYab,
		m_fXb,
		m_fYba,
		m_fYbb,
		m_fXc,
		m_fYca,
		m_fYcb;
	
	void Start () {
		for (int i = 0; i < m_xPlayer.m_iaPlayerAbilities.Count; i++){
			GameObject _xA = Instantiate(m_xOriginal);
			_xA.SetActive(true);
			_xA.transform.SetParent(this.transform);
		}
		
		GameObject _xB = Instantiate(m_xEndturnbutton);
		_xB.SetActive(true);
		_xB.transform.SetParent(this.transform);
		
		m_xaBattleMenuItems = GetComponentsInChildren<Battle_Menu_Item>();
		
		for (int i = 0; i < m_xaBattleMenuItems.GetLength(0); i++){
			if (i < m_xPlayer.m_iaPlayerAbilities.Count){
				m_xaBattleMenuItems[i].m_iAbility = m_xPlayer.m_iaPlayerAbilities[i];
			}
				
			m_xaBattleMenuItems[i].transform.localPosition = new Vector3(m_fXa, m_fYaa + i * m_fYab, 0);
			m_xaBattleMenuItems[i].m_xPanel.transform.localPosition = new Vector3(m_fXb, m_fYba + m_fYbb * i, 0);
			m_xaBattleMenuItems[i].m_xDesc.transform.localPosition = new Vector3(m_fXc, m_fYca + m_fYcb * i, 0);
		}
	}
	
	void Update () {
		/*for (int i = 0; i < m_xaBattleMenuItems.GetLength(0); i++){
			m_xaBattleMenuItems[i].transform.localPosition = new Vector3(m_fX, m_fYaa + i * m_fYab, 0);
			m_xaBattleMenuItems[i].m_xPanel.transform.localPosition = new Vector3(m_xaBattleMenuItems[i].m_xPanel.transform.position.x, m_fYba, 0);
			m_xaBattleMenuItems[i].m_xDesc.transform.localPosition = new Vector3(m_xaBattleMenuItems[i].m_xDesc.transform.position.x, m_fYbb, 0);
		}*/
	}
}