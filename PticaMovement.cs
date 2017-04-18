using UnityEngine;
using System.Collections;

public class PticaMovement : MonoBehaviour {

    
    float FlapBrzina = 100f;
    float BrzinaNaprijed = 1f;
    bool didFlap = false;
    public Rigidbody2D igrac;
    Animator animator;
    bool smrt = false;
    

    // Use this for initialization
    void Start() {
        animator =transform.GetComponentInChildren<Animator>();
        if(animator==null)
        {
            Debug.LogError("Nije se mogao pronaci animator");
        }

    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0)))
        {
            didFlap = true;
           
        }


    }



    // Update is called once per frame
    void FixedUpdate()

    {
        if (smrt)
            return;
        igrac = GetComponent<Rigidbody2D>();
        igrac.AddForce(Vector2.right * BrzinaNaprijed);

        if (didFlap)
        {
            igrac.AddForce(Vector2.up * FlapBrzina);
            animator.SetTrigger("DoFlap");

            didFlap = false;
        }

        if (igrac.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            float ugao = Mathf.Lerp(0, -90, (-igrac.velocity.y)/3f);
            transform.rotation = Quaternion.Euler(0, 0, ugao);
        }
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Smrt");
        smrt = true;
    }
}
