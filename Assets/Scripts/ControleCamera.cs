using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    
    private Vector3 decalage;
    private GameObject laBille;

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
    }
}
