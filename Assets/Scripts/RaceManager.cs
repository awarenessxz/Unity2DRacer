using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour {
    
    public EnemySpawner spawner;
    public RaceModeManager raceMode;
    public TrackMove track;
    public UIManager ui;

    public void StopGame()
    {
        track.TrackStop();
        spawner.SpawnStop();
        raceMode.gameEnded();
        ui.ShowMenu();
    }
}
