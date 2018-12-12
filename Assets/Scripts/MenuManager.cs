using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public string menuPage = "menu";
    public string aboutPage = "About";
    public string raceMode = "RacerMode";
    public string challengeMode = "ChallengeMode";
    public string destroyMode = "DestroyMode";
    private BackgroundAudio bg;

    // Use this for initialization
    void Start () {
        bg = GameObject.FindGameObjectWithTag("BgMusic").GetComponent<BackgroundAudio>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadRaceMode()
    {
        bg.StopMusic();
        SceneManager.LoadScene(raceMode);
    }

    public void LoadChallengeMode()
    {
        bg.StopMusic();
        SceneManager.LoadScene(challengeMode);
    }

    public void LoadDestoryMode()
    {
        bg.StopMusic();
        SceneManager.LoadScene(destroyMode);
    }

    public void LoadAboutPage()
    {
        SceneManager.LoadScene(aboutPage);
    }

    public void LoadMenuPage()
    {
        SceneManager.LoadScene(menuPage);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
