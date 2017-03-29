using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageEnableTriggerScript : MonoBehaviour
{

    public bool imageScreensEnabled = false;
    public bool buttonsActive = false;
    public bool enableActivateVideo = false;

    public GameObject pickUp;
    private PickupController pickupController;

    public GameObject playButton;
    public GameObject prevButton;
    public GameObject nextButton;

    public GameObject pickup1;
    public GameObject pickup2;
    public GameObject pickup3;

    // Use this for initialization
    void Start()
    {
        pickupController = pickUp.GetComponent<PickupController>();

        playButton.SetActive(false);
        prevButton.SetActive(false);
        nextButton.SetActive(false);

        pickup1.SetActive(false);
        pickup2.SetActive(false);
        pickup3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonsActive)
        {
            playButton.SetActive(true);
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }
        else
        {
            playButton.SetActive(false);
            prevButton.SetActive(false);
            nextButton.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && pickupController.noOfPickups == 3)
        {
            imageScreensEnabled = true;
            playButton.SetActive(true);
            prevButton.SetActive(true);
            nextButton.SetActive(true);
        }

        if (other.gameObject.tag == "Player" && pickupController.noOfPickups == 0)
        {
            pickup1.SetActive(true);
            pickup2.SetActive(true);
            pickup3.SetActive(true);

            enableActivateVideo = true;
        }
    }
}
