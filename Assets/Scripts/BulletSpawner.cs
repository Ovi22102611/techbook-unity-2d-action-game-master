using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulet,arrr;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SpawnArrow();

        }
      

        Destroy(arrr, 8f);
       
    }

    void SpawnArrow()
    {
      arrr= Instantiate(bulet, transform.position,bulet.transform.rotation);
    }
}
