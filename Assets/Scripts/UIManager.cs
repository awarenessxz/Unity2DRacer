using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public string menuPage = "menu";
    public Button[] buttons;
    public GameObject gameOverPanel;
    public Text gameOverMsgText;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void UpdateGameOverMsg(string msg)
    {
        gameOverMsgText.text = msg;
    }

    public void ShowMenu()
    {
        gameOverPanel.SetActive(true);
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
        SceneManager.LoadScene(menuPage);
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
