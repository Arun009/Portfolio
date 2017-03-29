using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImageScript : MonoBehaviour
{
    public Texture YawTexture;
    public Texture NickTexture;
    public Texture PushPullTexture;
    public Texture FPSTexture;
    public Texture PixaltoTexture;
    public Texture SkyrimTexture;
    public Texture GravityTexture;
    public Texture PlatformerTexture;
    public Texture UnrealTexture;

    public GameObject leftImageQuad;
    public GameObject midImageQuad;
    public GameObject rightImageQuad;

    public GameObject pickUp;

    private int middleImage;

    private CurrentImage imageController;
    private PickupController pickupController;

    // Use this for initialization
    void Start()
    {
        imageController = midImageQuad.GetComponent<CurrentImage>();
        imageController.currentImage = 1;

        leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = UnrealTexture;
        midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = YawTexture;
        rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = NickTexture;

        pickupController = pickUp.GetComponent<PickupController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pickupController.isPreviousButtonEnabled)
        {
            pickupController.isPreviousButtonEnabled = false;
            middleImage = imageController.currentImage;
            if (middleImage == 1)
                middleImage = 9;
            else
                middleImage--;
            StartCoroutine("waitForSeconds");
        }

        if (pickupController.isNextButtonEnabled)
        {
            pickupController.isNextButtonEnabled = false;
            middleImage = imageController.currentImage;
            if (middleImage == 9)
                middleImage = 1;
            else
                middleImage++;
            StartCoroutine("waitForSeconds");
        }

        if(Input.GetKeyDown(KeyCode.J))
            pickupController.isPreviousButtonEnabled = true;
        if (Input.GetKeyDown(KeyCode.L))
            pickupController.isNextButtonEnabled = true;
    }

    IEnumerator waitForSeconds()
    {
        yield return new WaitForSeconds(0.4f);
        UpdateImage();
    }

    void UpdateImage()
    {
        switch (middleImage)
        {
            case 1:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = UnrealTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = YawTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = NickTexture;
                    imageController.currentImage = 1;
                    break;
                }
            case 2:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = YawTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = NickTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PushPullTexture;
                    imageController.currentImage = 2;
                    break;
                }
            case 3:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = NickTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PushPullTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = FPSTexture;
                    imageController.currentImage = 3;
                    break;
                }
            case 4:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PushPullTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = FPSTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PixaltoTexture;
                    imageController.currentImage = 4;
                    break;
                }
            case 5:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = FPSTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PixaltoTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = SkyrimTexture;
                    imageController.currentImage = 5;
                    break;
                }
            case 6:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PixaltoTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = SkyrimTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = GravityTexture;
                    imageController.currentImage = 6;
                    break;
                }
            case 7:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = SkyrimTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = GravityTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PlatformerTexture;
                    imageController.currentImage = 7;
                    break;
                }
            case 8:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = GravityTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PlatformerTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = UnrealTexture;
                    imageController.currentImage = 8;
                    break;
                }
            case 9:
                {
                    leftImageQuad.GetComponent<MeshRenderer>().material.mainTexture = PlatformerTexture;
                    midImageQuad.GetComponent<MeshRenderer>().material.mainTexture = UnrealTexture;
                    rightImageQuad.GetComponent<MeshRenderer>().material.mainTexture = YawTexture;
                    imageController.currentImage = 9;
                    break;
                }
        }
    }
}

