using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scavengerScript : MonoBehaviour {
    public TrackableBehaviour myTrackableBehaviour;
	// Use this for initialization
	void Start () {
        myTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (myTrackableBehaviour.TrackableName == "Loggerhead")
        {
            Debug.Log("k");
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
