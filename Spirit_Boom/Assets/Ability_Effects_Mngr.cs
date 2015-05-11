using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ability_Effects_Mngr : MonoBehaviour {
	
	public List<ParticleSystem> 
		m_xaEffects,
		m_xaCurrentlyPlaying;
	
	public List<GameObject> m_xaPos;
	
	void Start(){
		ParticleSystem[] _xaPSs = GetComponentsInChildren<ParticleSystem>();
		
		for (int i = 0; i < _xaPSs.GetLength(0); i++){
			m_xaEffects.Add(_xaPSs[i]);
		}
	}
	
	void Update(){
		if (m_xaCurrentlyPlaying.Count > 0){
			for (int i = 0; i < m_xaCurrentlyPlaying.Count; i++){
				if (m_xaCurrentlyPlaying[i].GetComponents<ParticleEmitter>().GetLength(0) == 0){
					Destroy(m_xaCurrentlyPlaying[i]);
				}
			}
		}
	}
	
	public void Play_Effect (int p_iEffect, int _iPos){
		if (p_iEffect >= 0 && p_iEffect < m_xaEffects.Count){
			m_xaCurrentlyPlaying.Add(Instantiate(m_xaEffects[p_iEffect]));
			m_xaCurrentlyPlaying[m_xaCurrentlyPlaying.Count - 1].transform.position = Get_Pos(_iPos);
			m_xaCurrentlyPlaying[m_xaCurrentlyPlaying.Count - 1].transform.SetParent(this.transform);
		}
	}
	
	Vector3 Get_Pos(int p_i){
		if (p_i < 0 || p_i >= m_xaPos.Count){
			return new Vector3(0, 0, 0);
		}
		
		return m_xaPos[p_i].transform.position;
	}
}