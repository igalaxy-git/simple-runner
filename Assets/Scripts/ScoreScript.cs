﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text score;
    public static int scoreValue = 0;
    void Start()
    {
        score = GetComponent<Text>();
    }
    
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
