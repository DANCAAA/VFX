using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    Gradient colorGradient;
    //configuracion curva
    [SerializeField]
    AnimationCurve intensityOvertime;
    //
    float t = 0;
    Light mLight;
    ParticleSystem mParticleSys;
    ParticleSystem.MainModule mParticleMain;
    float duration;
    float speedLight;
    public float SpeedLight {
        get {
            return speedLight;
        }
        set {
            speedLight = value;
        }
    }


    // Use this for initialization
    void Start ()
    {      
        mLight = GetComponent<Light>();
        mParticleSys = GetComponentInParent<ParticleSystem>();
        mParticleMain = mParticleSys.main;
        //get the duration of the parcycle system
        duration = mParticleMain.duration;
    
    }

    // Update is called once per frame
    void Update()
    {
        //var main2 = mParticleSys.main;
        //main2.startSpeed = speedLight;
        

        //Time calculation
        t += (Time.deltaTime * speedLight) / duration ;
        mLight.color = colorGradient.Evaluate(t);

        //Intensidad luz
        mLight.intensity = intensityOvertime.Evaluate(t);

        ///
    }
}
