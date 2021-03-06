﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTransport : MonoBehaviour {

    public GameObject Target;

    public ScriptRegion.ResourceAmount Resources;

    public float Speed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Speed);


        if (transform.position.Equals(Target.transform.position))
        {
            var scriptRegion = Target.GetComponent<ScriptRegion>();
            scriptRegion.Deliver(Resources);
            Destroy(gameObject);
        }
 
    }
}
