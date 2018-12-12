using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceManager : MonoBehaviour {
    
    public EnemySpawner spawner;
    public RaceModeManager raceMode;
    public ChallengeModeManager challengeMode;
    public TrackMove track;
    public AudioManager am;
    public UIManager ui;
    public GameObject player;
    public Transform spawnPoint;
    private int spawnDelay = 2;

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "ChallengeMode")
        {
            InvokeRepeating("CheckChallengeStatus", 1f, 0.5f);
            raceMode = null;
        }
        else if (SceneManager.GetActiveScene().name == "RaceMode")
        {
            challengeMode = null;
        }
    }

    private void CheckChallengeStatus()
    {
        if (challengeMode.IsGameCleared())
        {
            StopGame();
        }
    }

    public void StopGame()
    {
        track.ToggleTrackStatus();
        spawner.ToggleSpawnStatus();
        if (SceneManager.GetActiveScene().name == "ChallengeMode")
        {
            challengeMode.TogglePlayerStatus();
            if (challengeMode.IsGameCleared())
            {
                ui.TogglePause();
                am.carSound.Stop();
                ui.UpdateGameOverMsg("You have cleared " + challengeMode.GetCarsCleared() + " cars.");
                ui.ShowMenu();
            }
            else
            {
                StartCoroutine("RevivePlayer");
            }
        }
        else if (SceneManager.GetActiveScene().name == "RacerMode")
        {
            raceMode.GameEnded();
            ui.ShowMenu();
        }
    }

    public IEnumerator RevivePlayer()
    {
        // [TODO]: Add Sound Effect
        yield return new WaitForSeconds(spawnDelay);

        Instantiate(player, spawnPoint.position, spawnPoint.rotation);
        track.ToggleTrackStatus();
        spawner.ToggleSpawnStatus();
        challengeMode.TogglePlayerStatus();
    }
}
