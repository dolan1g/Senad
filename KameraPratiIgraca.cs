using UnityEngine;
using System.Collections;

public class KameraPratiIgraca : MonoBehaviour {
    Transform igrac;
    float offsetX;
	// Use this for initialization
	void Start () {

        GameObject igrac_go = GameObject.FindGameObjectWithTag("Player");
        if(igrac_go==null)
        {
            Debug.LogError("Nije se mogao pronaci objekat sa tagom Player");
            return;
        }
        igrac = igrac_go.transform;
        offsetX = transform.position.x - igrac.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (igrac != null)
        {
            Vector3 pozicija = transform.position;
            pozicija.x = igrac.position.x + offsetX;
            transform.position = pozicija;
        }
        
	
	}
}
