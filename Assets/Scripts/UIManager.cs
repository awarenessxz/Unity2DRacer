using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public Text scoreText;
    public Button[] buttons;
    int score;
    bool gameOver;

	// Use this for initialization
	void Start () {
        score = 0;
        gameOver = false;
        InvokeRepeating("ScoreUpdate", 1f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
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

    public void ShowMenu()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    // replay Game
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Exit Game
    public void Exit()
    {
        Application.Quit();
    }

    // Pause Game
    public void TogglePause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
