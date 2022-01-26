using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    public GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayerSpawner",0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerSpawner()
    {
        Instantiate(playerObj,playerObj.transform.position,playerObj.transform.rotation);
    }
}
