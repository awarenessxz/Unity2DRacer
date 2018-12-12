using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyModeManager : MonoBehaviour {

    public Text scoreText;
    private int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    public void addScore()
    {
        score += 1;
    }

}
