using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class particleEmit : MonoBehaviour {

	public Collider2D playerCollider;
	public Collider2D particleTrigger;
	public ParticleSystem runeParticles;


	void Start(){

		runeParticles.enableEmission = false;
		runeParticles.Play ();
	}

	void Update () {
	
		if (playerCollider.IsTouching (particleTrigger)) {
//			if (!runeParticles.isPlaying){
				runeParticles.enableEmission = true;

	//			runeParticles.Play ();
//			}
		} 
		else {

//			if (runeParticles.isPlaying){
				runeParticles.enableEmission = false;
	//			runeParticles.Stop ();
//			}
		}
	}

}