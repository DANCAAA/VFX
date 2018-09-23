using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorController : MonoBehaviour {

    [SerializeField]
    AnimationCurve ProjectorIntensity;

    [SerializeField]
    float size;
    Projector mProjector;

    void Start () {
        mProjector = GetComponent<Projector>();
        mProjector.orthographicSize = size * 1.5f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
