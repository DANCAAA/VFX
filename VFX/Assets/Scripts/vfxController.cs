using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxController : MonoBehaviour
{
    ParticleSystem ps;
    public float speed;
    void Start () {
        ps = GetComponent<ParticleSystem>();
        GetComponentInParent<AnimTime>().AnimationSpeed = speed;
        GetComponentInChildren<LightController>().SpeedLight = speed;
        //GetComponentInChildren<ParticleSystem>().main.simulationSpeed = speed;
    }
	
	// Update is called once per frame
	void Update () {
        var main = ps.main;
        // main.startSpeed = speed; // asignacion valor velocidad
        main.simulationSpeed = speed;
    }
}
