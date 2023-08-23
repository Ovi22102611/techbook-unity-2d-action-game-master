using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timer : MonoBehaviour
{
    float speed = 0.0005f;
    float originalVal = 1f;
    bool chk = true;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(originalVal, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (chk == true)
        {
            StartCoroutine(Ttimer());
        }
        if (originalVal <= 0)
        {
            SceneManager.LoadScene(0);

        }

       
    //Timer();

}

   /* void Timer()
    {
        if (originalVal > 0)
        {
            transform.localScale = new Vector3(originalVal *Time.deltaTime, 1, 1);
            originalVal = originalVal - speed;

        }


    }*/

    IEnumerator Ttimer()
    {
        chk = false;
        if (originalVal > 0)
        {
            transform.localScale = new Vector3(originalVal, 1, 1);
            originalVal = originalVal - speed;
            yield return new WaitForSeconds(0.01f);

        }
        chk = true;

        
    }

}
