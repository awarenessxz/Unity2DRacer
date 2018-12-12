using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DelayStart : MonoBehaviour {

    public GameObject gameOverPanel;
    public Text gameTitleText;
    public Text gameInstructionText;
    public GameObject countDown;
    public AudioManager am;

    // Use this for initialization
    void Start ()
    {
        if (SceneManager.GetActiveScene().name == "ChallengeMode")
        {
            gameTitleText.text = "Mode: 1 min Challenge";
            gameInstructionText.text = "Clear as many cars as you can in 1 minute";
        }
        else if (SceneManager.GetActiveScene().name == "DestroyMode")
        {
            gameTitleText.text = "Mode: Destroy";
            gameInstructionText.text = "Have Fun and Destroy!";
        }
        else
        {
            gameTitleText.text = "Mode: Race";
            gameInstructionText.text = "You only have 1 life, Survive for as long as you can!";
        }
        StartCoroutine("StartDelay");
    }
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator StartDelay()
    {
        am.countDownSound.Play();
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while(Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        gameOverPanel.SetActive(false);
        countDown.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
