using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesScript : MonoBehaviour {
	public ParticleSystem projectile;
	public ParticleSystem impact;
	public bool exploded = false;

	public GameObject projectle;
	// Use this for initialization
	void Start () {
		projectile.Play();
		impact.Stop();
	}
	
	void OnTriggerEnter()
	{
		if(exploded == false){
		projectile.Stop();
		impact.Play();
		projectle.SetActive(false);
		exploded = true;
		}
	}
}
