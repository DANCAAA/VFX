using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem mParticleSys;
    ParticleSystem.MainModule mParticleMain;
    float duration;
    float speedParticle;
    public float SpeedParticle
    {
        get
        {
            return speedParticle;
        }
        set
        {
            speedParticle = value;
        }
    }


    // Use this for initialization
    void Start () {
        mParticleSys = GetComponentInParent<ParticleSystem>();
       
        //get the duration of the parcycle system

    }
	
	// Update is called once per frame
	void Update () {
        mParticleMain = mParticleSys.main;
        mParticleMain.simulationSpeed = speedParticle;
    }
}
