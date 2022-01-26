using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    private Camera cam;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        cam=GetComponent<Camera>();
        cam.enabled = true;
        if (cam)
        {
            //This enables the orthographic mode
            cam.orthographic = true;
            //Set the size of the viewing volume you'd like the orthographic Camera to pick up (5)
            cam.orthographicSize = 5.0f;
            //Set the orthographic Camera Viewport size and position
           cam.rect = new Rect(cam.transform.position.x, cam.transform.position.y - 5f, cam.transform.position.z - 3f,0.4f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeCameraPos()
    {
        Vector3 pos = new Vector3();
        cam.transform.Translate(pos * speed * Time.deltaTime);
    }
}
