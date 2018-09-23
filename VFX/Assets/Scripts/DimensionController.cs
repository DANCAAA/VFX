using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionController : MonoBehaviour {
    [SerializeField]
    public float dimension;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(dimension, dimension, dimension);
    }
}
