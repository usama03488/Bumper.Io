using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Size : MonoBehaviour
{
    public GameObject players;
    private Transform player;
    public GameObject ene;
    private Transform enyme;
    private Vector3 camerainitial;
    private Vector3 position;
    private float speed = 5f;
    public Camera cam;
    public bool enemyClose = false;
    private float camerasize = 10f;
  
    // Start is called before the first frame update
    void Start()
    {
        player = players.GetComponent<Transform>().transform;
        enyme = ene.GetComponent<Transform>().transform;
      
       
        //cam.enabled = true;
        //if (cam)
        //{
        //    //This enables the orthographic mode
        //    cam.orthographic = true;
        //    //Set the size of the viewing volume you'd like the orthographic Camera to pick up (5)
        //    cam.orthographicSize = 9.0f;
        //    //Set the orthographic Camera Viewport size and position
        //    cam.rect = new Rect(cam.transform.position.x, cam.transform.position.y , 0.4f, 0.4f);
        //}
    }
       

    // Update is called once per frame
    void Update()
    {
      
        if (player != null & enyme != null && cam!=null)
        {
            transform.position = player.position;
            camerasize = cam.orthographicSize;
            position =  enyme.position - player.position;
            if ((position.x < 1f && position.x> -1) || (position.z < 1f && position.z>-1f) && camerasize > 6f && camerasize<11f)
            {
                cam.orthographicSize-= 0.2f * Time.deltaTime * speed;
               
            }
            else if (position.x > 1f || position.x<-1f || position.z > 1f || position.z<-1f && camerasize < 6)
            {
                cam.orthographicSize += 0.2f * Time.deltaTime * speed;
           
            }
       
        }
       

      

    }
}
