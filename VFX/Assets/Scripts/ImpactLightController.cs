using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactLightController : MonoBehaviour {

    [SerializeField]
    AnimationCurve intensityOvertime;
    float t = 0;
    Light mLight;
    float duration;
    [SerializeField]
    float speedLight;
    ParticleSystem mParticleSys;
    ParticleSystem.MainModule mParticleMain;
    // Use this for initialization

    void Start () {
        mLight = GetComponent<Light>();
        mParticleSys = GetComponentInParent<ParticleSystem>();
        mParticleMain = mParticleSys.main;
        //get the duration of the parcycle system
        duration = mParticleMain.duration;
    }
	
	// Update is called once per frame
	void Update () {
        t += (Time.deltaTime * speedLight) / duration;
        mLight.intensity = intensityOvertime.Evaluate(t);
    }
}
