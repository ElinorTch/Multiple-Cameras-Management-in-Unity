using UnityEngine;

public class GeneralScript : MonoBehaviour
{

    Camera followedCam, onTopCam, currentCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
        Camera[] cameras = FindObjectsOfType<Camera>();
        foreach (Camera cam in cameras)
        {
            if (cam.name == "FollowedCam")
            {
                followedCam = cam;
                Debug.Log("Found followed cam");
            }
            else if (cam.name == "OnTopCam")
            {
                onTopCam = cam;
                Debug.Log("Found on top cam");
            }
        }

        followedCam.enabled = true;
        onTopCam.enabled = false;
        currentCam = followedCam;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (currentCam == followedCam)
            {
                followedCam.enabled = false;
                onTopCam.enabled = true;
                currentCam = onTopCam;
            }
            else
            {
                onTopCam.enabled = false;
                followedCam.enabled = true;
                currentCam = followedCam;
            }
        }
    }
}
