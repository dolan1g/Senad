using UnityEngine;
using System.Collections;

public class PodMover : MonoBehaviour {


    Rigidbody2D igrac;
    void Start()
    {

        GameObject igrac_go = GameObject.FindGameObjectWithTag("Player");
        if (igrac_go == null)
        {
            Debug.LogError("Nije se mogao pronaci objekat sa tagom Player");
            return;
        }
        igrac = igrac_go.GetComponent<Rigidbody2D>();
       
       
    }

    void FixedUpdate()

    {
        float ubrzanje = igrac.velocity.x * 0.75f;
        transform.position = transform.position + Vector3.right * ubrzanje * Time.deltaTime;
        
	}
}
