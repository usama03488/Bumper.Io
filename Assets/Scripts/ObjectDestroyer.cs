using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
  
    private GameObject player=null;
    public Texture mate;
    private Renderer rend;
    private Vector3 scales;

    public bool enemyCollider = false;
    private Vector3 local = new Vector3(1f, 1f, 1f);
    // Start is called before the first frame update
    void Start()
    {


      

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1 && player !=null)
        {
            player.transform.localScale += local;
           player.GetComponent<Rigidbody>().mass +=2;
            rend =player.GetComponent<Renderer>();
            rend.material.EnableKeyword("_NORMALMAP");
            rend.material.EnableKeyword("_METALLICGLOSSMAP");
            rend.material.SetTexture("_MainTex",mate);
            //size increases
            Destroy(gameObject);
        }
        else if(transform.position.y < -2)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject != null)
        {
            if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Player"))
            {
                player = collision.gameObject;
               
            }

        }
        
    
      
    }
}
