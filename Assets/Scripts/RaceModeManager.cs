using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceModeManager : MonoBehaviour {

    public Text scoreText;
    private bool gameOver;
    private int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        gameOver = false;
        InvokeRepeating("ScoreUpdate", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    // Method to update Score
    void ScoreUpdate()
    {
        if (!gameOver)
        {
            score += 1;
        }
    }

    public void GameEnded()
    {
        gameOver = true;
    }
}
