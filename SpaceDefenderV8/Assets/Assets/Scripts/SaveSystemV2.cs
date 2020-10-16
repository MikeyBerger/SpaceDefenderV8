﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSystemV2 
{
    public int Score;
    public int HiScore;
    public Text ScoreText;
    public Text HiScoreText;
    private GameMaster GM;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Score = 0;
        HiScore = PlayerPrefs.GetInt("HiScore");
        */
        GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameMaster>();
        Score = GM.Score;
        HiScore = GM.HiScore;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Score > HiScore)
        {
            HiScore = Score;
            PlayerPrefs.SetInt("HiScore", HiScore);
        }

        ScoreText.text = "Score: " + Score.ToString();
        HiScoreText.text = "HighScore: " + HiScore.ToString();
        */
        GM.Update();
    }
}
