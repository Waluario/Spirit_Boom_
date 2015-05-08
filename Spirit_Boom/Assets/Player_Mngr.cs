using UnityEngine;
using System.Collections;

public class Player_Mngr : MonoBehaviour {
	
	// Static:
	public static string m_xsName;
	
	public static int
		m_isHp,
		m_isMhpBase,
		m_isMhpModd,
		m_isMapBase,
		m_isMapModd,
		m_isAprBase,
		m_isAprModd,
		m_isAtkBase,
		m_isAtkModd,
		m_isDefBase,
		m_isDefModd,
		m_isFdfBase,
		m_isFdfModd,
		m_isWdfBase,
		m_isWdfModd,
		m_isEdfBase,
		m_isEdfModd,
		m_isAccBase,
		m_isAccModd,
		m_isEvaBase,
		m_isEvaModd;
		
	public static long
		m_isExp,
		m_isExpNext;
	
	public static int[] m_iasAbilities;
	
	// Non-Static:
	public string m_xName;
	
	public int
		m_iHp,
		m_iMhpBase,
		m_iMhpModd,
		m_iMapBase,
		m_iMapModd,
		m_iAprBase,
		m_iAprModd,
		m_iAtkBase,
		m_iAtkModd,
		m_iDefBase,
		m_iDefModd,
		m_iFdfBase,
		m_iFdfModd,
		m_iWdfBase,
		m_iWdfModd,
		m_iEdfBase,
		m_iEdfModd,
		m_iAccBase,
		m_iAccModd,
		m_iEvaBase,
		m_iEvaModd;
		
	public long 
		m_iExp,
		m_iExpNext;
	
	public int[] m_iaAbilities;
	
	public bool m_bSetVariables;
	
	void Start () {
		if (m_bSetVariables){
			m_xsName = m_xName;
			
			m_isHp = m_iHp;
			m_isMhpBase = m_iMhpBase;
			m_isMhpModd = m_iMhpModd;
			m_isMapBase = m_iMapBase;
			m_isMapModd = m_iMapModd;
			m_isAprBase = m_iAprBase;
			m_isAprModd = m_iAprModd;
			m_isAtkBase = m_iAtkBase;
			m_isAtkModd = m_iAtkModd;
			m_isDefBase = m_iDefBase;
			m_isDefModd = m_iDefModd;
			m_isFdfBase = m_iFdfBase;
			m_isFdfModd = m_iFdfModd;
			m_isWdfBase = m_iWdfBase;
			m_isWdfModd = m_iWdfModd;
			m_isEdfBase = m_iEdfBase;
			m_isEdfModd = m_iEdfModd;
			m_isAccBase = m_iAccBase;
			m_isAccModd = m_iAccModd;
			m_isEvaBase = m_iEvaBase;
			m_isEvaModd = m_iEvaModd;
			m_isExp = m_iExp;
			m_isExpNext = m_iExpNext;
			
			m_iasAbilities = m_iaAbilities;
		}
	}
	
	void Update () {
		
	}
}