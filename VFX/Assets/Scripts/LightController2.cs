using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController2 : MonoBehaviour {
    [SerializeField]
    Gradient colorGradient;
    //configuracion curva
    [SerializeField]
    AnimationCurve intensityOvertime;
    //
    float t = 0;
    Light mLight;
    float duration = 45f;
    float speedLight =5.0f;
    // Use this for initialization
    void Start () {
        mLight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        t += (Time.deltaTime * speedLight) / duration;
        mLight.color = colorGradient.Evaluate(t);

        //Intensidad luz
        mLight.intensity = intensityOvertime.Evaluate(t);
    }
}
