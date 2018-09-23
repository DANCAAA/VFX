using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshesController : MonoBehaviour {
    ParticleSystem ps;
    public float SpeedVfx;
    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var main = ps.main;
        // main.startSpeed = speed; // asignacion valor velocidad
        main.simulationSpeed = SpeedVfx;
    }
}
