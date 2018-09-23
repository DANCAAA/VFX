using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxController : MonoBehaviour
{
    ParticleSystem ps;
    /*
    ParticleSystem ps2;
    ParticleSystem ps3;
    ParticleSystem ps4;
    ParticleSystem ps5;

    ParticleSystem.MainModule psMain;
    ParticleSystem.MainModule psMain2;
    ParticleSystem.MainModule psMain3;
    ParticleSystem.MainModule psMain4;
    ParticleSystem.MainModule psMain5; */

    public float SpeedVfx = 1.0f;




    void Start () {
        ps = GetComponent<ParticleSystem>();
        GetComponentInParent<AnimTime>().AnimationSpeed = SpeedVfx;
        GetComponentInChildren<LightController>().SpeedLight = SpeedVfx;
        //GetComponentInChildren<ParticleController>().SpeedParticle = SpeedVfx;

        /*
        ps2 = GameObject.Find("HeathPower").GetComponent<ParticleSystem>();
        psMain2 = ps2.main;

        ps3 = GameObject.Find("Ashes").GetComponent<ParticleSystem>();
        psMain3 = ps2.main;

        ps4 = GameObject.Find("HeathBlast").GetComponent<ParticleSystem>();
        psMain4 = ps4.main;


        ps5 = GameObject.Find("HeathBlast").GetComponent<ParticleSystem>();
        psMain5 = ps5.main; */


        //GetComponentInChildren<ParticleSystem>().main.simulationSpeed = speed;
    }
	
	// Update is called once per frame
	void Update () {
       var main = ps.main;
        // main.startSpeed = speed; // asignacion valor velocidad
       main.simulationSpeed = SpeedVfx;
       

        /*
        psMain2.simulationSpeed = SpeedVfx;
        psMain3.simulationSpeed = SpeedVfx;
        psMain4.simulationSpeed = SpeedVfx;
        psMain5.simulationSpeed = SpeedVfx;
        */


    }
}
