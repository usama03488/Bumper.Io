using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public bool Iscollide = false;
   
    public float speed = 100.0f;
    private GameObject FocalPoint;
    private GameObject EnemyBall;
  
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        FocalPoint = GameObject.Find("FocalPoint");
        EnemyBall = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S))
        {
            float Verticalinput = Input.GetAxis("Vertical");
            rb.AddForce(FocalPoint.transform.forward *Verticalinput*20);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            float Horizontalinput = Input.GetAxis("Horizontal");
            rb.AddForce(FocalPoint.transform.right *Horizontalinput *20  );

        }
     
            //float Horizontalinput = Input.GetAxis("Horizontal");
            //rb.AddForce(FocalPoint.transform.right *speed *Time.deltaTime * Horizontalinput);
    
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

}
