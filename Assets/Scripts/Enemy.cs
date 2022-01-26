using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
     private  GameObject player;

    public float speed=3.0f;

    // Start is called before the first frame update
    void Start()
    {
    
        rb =GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            Vector3 forwardpos = (player.transform.position - transform.position).normalized;
            rb.AddForce(forwardpos * speed);
        }
      
      
    }
  
}
