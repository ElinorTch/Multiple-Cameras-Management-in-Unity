using UnityEngine;

public class EventCubeCollision : MonoBehaviour
{
    private GameObject destination;
    private GameObject laBille;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        laBille = GameObject.Find("Bille");
        destination = GameObject.Find("Destination");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with " + other.gameObject.name);
        Debug.Log("Function trigger" + other.gameObject.name);
        laBille.transform.position = new Vector3(destination.transform.position.x, laBille.transform.position.y, destination.transform.position.z);

        laBille.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        laBille.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
