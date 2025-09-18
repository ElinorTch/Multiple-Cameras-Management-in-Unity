using UnityEngine;
using UnityEngine.AI;

public class GeneralScript : MonoBehaviour
{
    private GameObject bille;
    Camera followedCam, onTopCam, currentCam;
    private NavMeshAgent garde;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
        bille = GameObject.Find("Bille");
        garde = GameObject.Find("Garde").GetComponent<NavMeshAgent>();

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
        garde.destination = bille.transform.position;

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
