using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject SpawnEnemy;
    private GameObject playerball;
    public float[] locationX ;
    public float[] locationZ;
    // Start is called before the first frame update
    void Start()
    {
        playerball = GameObject.Find("Player");
        for(int i = 0; i < locationX.Length; i++)
        {
            float SpawnX = Random.Range(-9, 9);
            locationX[i] = SpawnX;
        }
        for (int i = 0; i < locationX.Length; i++)
        {
            float SpawnX = Random.Range(-9, 9);
            locationZ[i] = SpawnX;
        }
        Invoke("spawner",0f);

    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    private void spawner()
    {
        for(int i = 0; i < locationX.Length; i++)
        {
            Vector3 spawnPos = new Vector3(locationX[i],1,locationZ[i]);
            Instantiate(SpawnEnemy, spawnPos, SpawnEnemy.transform.rotation);
        }
      
    }
   
}
