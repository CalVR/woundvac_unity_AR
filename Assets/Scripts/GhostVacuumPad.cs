﻿using UnityEngine;
using System.Collections;

public class GhostVacuumPad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    // Update is called once per frame
    void Update()
    {
        if (transform.parent == null || transform.parent.tag != "VuforiaTrackerPad")
        {
            GameObject tracker = GameObject.FindGameObjectWithTag("VuforiaTrackerPad");
            if (tracker != null)
            {
                transform.parent = tracker.transform;
                transform.localPosition = new Vector3(4f, 0.1f, 20f);
            }
        }

    }
}
