using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour
{

    int numBGPanels = 6;
    float CijeviMax = 3.10f;
    float CijeviMin = 2.25f;



    void Start()
    {
        GameObject[] cijevi = GameObject.FindGameObjectsWithTag("Cijevi");
        foreach (GameObject cijev in cijevi)
        {
            Vector3 pozicija = cijev.transform.position;
            pozicija.y = Random.Range(CijeviMin, CijeviMax);
            cijev.transform.position = pozicija;
        }

    }

    
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered: " + collider.name);

        float SirinaBGOBjekta = ((BoxCollider2D)collider).size.x;
        Vector3 pozicija = collider.transform.position;
        pozicija.x += SirinaBGOBjekta * numBGPanels;
        if(collider.tag=="Cijevi")
        {
            pozicija.y = Random.Range(CijeviMin, CijeviMax);
        }
        collider.transform.position = pozicija;

    }
}
