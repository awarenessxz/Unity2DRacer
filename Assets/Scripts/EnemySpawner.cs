using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] enemies;
    public float boundaryLeft = -1.9f;
    public float boundaryRight = 2f;
    public float delayTimer;
    float timer;

    // Use this for initialization
    void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(boundaryLeft, boundaryRight), transform.position.y, transform.position.z);
            int index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
