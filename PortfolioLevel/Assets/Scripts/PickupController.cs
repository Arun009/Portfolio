using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {

    public bool isPlayButtonEnabled = false;
    public bool isPreviousButtonEnabled = false;
    public bool isNextButtonEnabled = false;

    public bool isVideoPlaying = false;

    public int noOfPickups = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickups")
        {
            Debug.Log("Pickup");
            Destroy(other.gameObject);
            noOfPickups++;
        }

        if (other.gameObject.tag == "PlayButton")
        {
            Debug.Log("Play");
            isPlayButtonEnabled = true;
            isVideoPlaying = true;
        }

        if (other.gameObject.tag == "PreviousButton")
        {
            Debug.Log("Previous");
            isPreviousButtonEnabled = true;
        }

        if (other.gameObject.tag == "NextButton")
        {
            Debug.Log("Next");
            isNextButtonEnabled = true;
        }
    }
}
