﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text MyScore;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScore.text = " " + ScoreNum;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "apple")
        {
            ScoreNum++;
            MyScore.text = " " + ScoreNum;

        }
    }
}
