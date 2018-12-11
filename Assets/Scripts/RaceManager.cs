using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour {
    
    public EnemySpawner spawner;
    public TrackMove track;
    public UIManager ui;

    public void StopGame()
    {
        track.TrackStop();
        spawner.SpawnStop();
        ui.ShowMenu();
    }
}
