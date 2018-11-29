using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scavengerScript : DefaultTrackableEventHandler {
    /*public TrackableBehaviour myTrackableBehaviour;*/


    public string imageName;

    protected override void Start()
    {
        Debug.Log("My turtle is: " + PlayerPrefs.GetInt("LoggerT"));
        Debug.Log("My Hawksbill is: " + PlayerPrefs.GetInt("HawksbillT"));
        Debug.Log("My Green is: " + PlayerPrefs.GetInt("GreenT"));
    }


    protected override void OnTrackingFound()
    {
        PlayerPrefs.SetInt(imageName, 1);
    }
}
