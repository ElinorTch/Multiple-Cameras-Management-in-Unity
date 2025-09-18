using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    
    private Vector3 decalage;
    private GameObject laBille;
    public float zoomSpeed = 10f;
    public float minFOV = 15f;
    public float maxFOV = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        laBille = GameObject.Find("Bille");
        decalage = laBille.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = laBille.transform.position - decalage;

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView -= scroll * zoomSpeed;
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minFOV, maxFOV);
    }
}
