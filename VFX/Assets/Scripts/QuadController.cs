using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour
{
    [SerializeField]
    Gradient colorGradient;

    [SerializeField]
    float quadSpeed = 1.0f;

    float t = 0;
    MeshRenderer mQuad;
    ParticleSystem mParticleSys;
    ParticleSystem.MainModule mParticleMain;
    float duration;

    // Use this for initialization
    void Start ()
    {
        mQuad = GetComponent<MeshRenderer>();
        mParticleSys = GetComponentInParent<ParticleSystem>();
       // mParticleMain = mParticleSys.main;
        //get the duration of the parcycle system
        duration = mParticleMain.duration;
    }
	
	// Update is called once per frame
	void Update () {
        //mQuad.material.color *= colorGradient.Evaluate(t);
       // t += (Time.deltaTime * quadSpeed) / duration;
       
    }
}
