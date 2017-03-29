using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour {

    public GameObject pickUp;
    public GameObject midImageQuad;
    public GameObject trigger;

    WebGLMovieTexture movTexture;

    private PickupController pickupController;
    private CurrentImage imageController;
    private ImageEnableTriggerScript triggerScript;

    enum videoToBePlayed
    {
        Activate,
        Yaw,
        Nick,
        PushOrPull,
        FPS,
        Pixalto,
        Skyrim,
        Gravity,
        Platformer,
        Unreal,
        Default,
    };

    private videoToBePlayed video;

    void Start()
    {
        pickupController = pickUp.GetComponent<PickupController>();
        imageController = midImageQuad.GetComponent<CurrentImage>();
        triggerScript = trigger.GetComponent<ImageEnableTriggerScript>();

        movTexture = new WebGLMovieTexture("StreamingAssets/InitialVideo.mp4");
        GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
        GetComponent<MeshRenderer>().material.mainTexture = movTexture;
        movTexture.Play();
    }

    void Update()
    {
        movTexture.Update();
        if (triggerScript.enableActivateVideo)
        {
            triggerScript.enableActivateVideo = false;
            video = videoToBePlayed.Activate;
            PlayVideo();
        }
        switch (imageController.currentImage)
        {
            case 1:
                {
                    video = videoToBePlayed.Yaw;
                    break;
                }
            case 2:
                {
                    video = videoToBePlayed.Nick;
                    break;
                }
            case 3:
                {
                    video = videoToBePlayed.PushOrPull;
                    break;
                }
            case 4:
                {
                    video = videoToBePlayed.FPS;
                    break;
                }
            case 5:
                {
                    video = videoToBePlayed.Pixalto;
                    break;
                }
            case 6:
                {
                    video = videoToBePlayed.Skyrim;
                    break;
                }
            case 7:
                {
                    video = videoToBePlayed.Gravity;
                    break;
                }
            case 8:
                {
                    video = videoToBePlayed.Platformer;
                    break;
                }
            case 9:
                {
                    video = videoToBePlayed.Unreal;
                    break;
                }
        }
        if (pickupController.isVideoPlaying)
        {
            if (movTexture.time == movTexture.duration)
                pickupController.isVideoPlaying = false;

            if (pickupController.isPlayButtonEnabled)
            {
                if (movTexture.time < movTexture.duration)
                    pickupController.isPlayButtonEnabled = false;
                else
                    PlayVideo();
            }
        }
    }

    void PlayVideo()
    {
        switch (video)
        {
            case videoToBePlayed.Activate:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/ActivateVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Yaw:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/YawVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Nick:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/NickVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.PushOrPull:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/PushOrPullVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.FPS:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/LumberyardFPSVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Pixalto:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/PixaltoVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Skyrim:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/SkyrimVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Gravity:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/GravityVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Platformer:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/MarioLikeVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Unreal:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/UnrealVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                };
            case videoToBePlayed.Default:
                {
                    Destroy(movTexture);
                    //GetComponent<AudioSource>().Stop();

                    pickupController.isPlayButtonEnabled = false;
                    movTexture = new WebGLMovieTexture("StreamingAssets/InitialVideo.mp4");
                    GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    GetComponent<MeshRenderer>().material.mainTexture = movTexture;
                    movTexture.Play();
                    break;
                }
        }
    }
}
