using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticlesOnClick : MonoBehaviour
{

	public float Count = 1;
	public GameObject particleEmitter;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			particleEmitter.GetComponent<ParticleSystem>().Emit(1);
		}
	}

}
