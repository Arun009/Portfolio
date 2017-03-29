using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour {

    public GameObject pickUp;
    private PickupController pickupController;

    public GameObject trigger;
    private ImageEnableTriggerScript triggerScript;

    public GameObject midBackQuad;

    // Use this for initialization
    void Start () {

        pickupController = pickUp.GetComponent<PickupController>();
        triggerScript = trigger.GetComponent<ImageEnableTriggerScript>();

        Color color = GetComponent<MeshRenderer>().material.color;
        color.a = 0.0f;
        GetComponent<MeshRenderer>().material.color = color;

        Color color1 = midBackQuad.GetComponent<MeshRenderer>().material.color;
        color1.a = 0.0f;
        midBackQuad.GetComponent<MeshRenderer>().material.color = color;
    }
	
	// Update is called once per frame
	void Update () {
        if (pickupController.isVideoPlaying)
        {
            if (GetComponent<MeshRenderer>().material.color.a >= 0.0f)
                StartCoroutine("FadeOut");
            triggerScript.buttonsActive = false;
        }
        else
        {
            if (pickupController.noOfPickups == 3 && triggerScript.imageScreensEnabled)
            {
                if (GetComponent<MeshRenderer>().material.color.a <= 0.9f)
                    StartCoroutine("FadeIn");
                triggerScript.buttonsActive = true;
            }
        }
    }

    IEnumerator FadeOut()
    {
        float i = GetComponent<MeshRenderer>().material.color.a;
        for (float f = i; f >= 0; f -= 0.01f)
        {
            Color color = GetComponent<MeshRenderer>().material.color;
            color.a = f;
            GetComponent<MeshRenderer>().material.color = color;

            Color color1 = midBackQuad.GetComponent<MeshRenderer>().material.color;
            color1.a = f;
            midBackQuad.GetComponent<MeshRenderer>().material.color = color;
            yield return null;
        }
    }

    IEnumerator FadeIn()
    {
        float i = GetComponent<MeshRenderer>().material.color.a;
        for (float f = i; f <= 0.9f; f += 0.01f)
        {
            Color color = GetComponent<MeshRenderer>().material.color;
            color.a = f;
            GetComponent<MeshRenderer>().material.color = color;

            Color color1 = midBackQuad.GetComponent<MeshRenderer>().material.color;
            color1.a = f;
            midBackQuad.GetComponent<MeshRenderer>().material.color = color;
            yield return null;
        }
    }
}
