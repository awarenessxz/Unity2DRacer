using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeModeManager : MonoBehaviour {

    public Text timerText;
    public Text clearedText;
    private float startTime;
    private bool finished;
    private bool alive;
    private int carsLeft;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        carsLeft = 100;
        finished = false;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            float curTime = Time.time - startTime;
            // check if condition of game mode have been met
            CheckFinished(curTime);           

            string minutes = ((int)curTime / 60).ToString();
            string seconds = (curTime % 60).ToString("f2");

            timerText.text = "Time : " + minutes + ":" + seconds;
            clearedText.text = "Cars Left : " + carsLeft;
        }
    }

    // Check if conditions for Race End have been met
    private void CheckFinished(float curTime)
    {
        if (carsLeft <= 0 || curTime > 60)
        {
            finished = true;
        }
    }

    // Update Cleared Cars Counter only when player is alive
    public void UpdateCarsCleared()
    {
        if (alive)
        {
            carsLeft -= 1;
        }
    }

    // Toggle Player Alive status
    public void TogglePlayerStatus()
    {
        alive = !alive;
    }

    // Update Race Ended
    public bool IsGameCleared()
    {
        return finished;
    }

    public int GetCarsCleared()
    {
        return 100 - carsLeft;
    }
}
