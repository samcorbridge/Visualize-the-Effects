using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAnimatorController : MonoBehaviour
{

    public Animator Anims;
    public ParticleSystem Particles;
    public float TurnOffTime;

    private void Start()
    {
        Anims = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))

            {
                Anims.SetBool("Shoot", true);
               // anim.Play(anim.clip.name);
                GetComponent<Animation>().Play();
                Particles.Play();
                StartCoroutine(TurnOff());

            }
    }

    IEnumerator TurnOff()
    {
        print("corouting estarted");
        yield return new WaitForSeconds(TurnOffTime);
        Particles.Stop();
        Anims.SetBool("Shoot", false);
    }
}
