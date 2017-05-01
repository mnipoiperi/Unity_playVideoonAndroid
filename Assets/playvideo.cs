using UnityEngine;
using System.Collections;

public class playvideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Handheld.PlayFullScreenMovie("Gondola Ride In Venice.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
