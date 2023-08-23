using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject arrow,arr;
    public float spawnRate = 3;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
           
        }
        else
        {
            SpawnArrow();
            timer = 0;

        }

        Destroy(arr, 8f);
       
    }

    void SpawnArrow()
    {
      arr= Instantiate(arrow, transform.position,new Quaternion(0,0,-180,0));
    }
}
