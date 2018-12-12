using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRespawn : MonoBehaviour {

    public GameObject countDown;
    public AudioManager am;

    // Use this for initialization
    void Start () {
        StartCoroutine("StartRespawn");
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator StartRespawn()
    {
        am.countDownSound.Play();
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        am.carSound.Play();
        countDown.gameObject.SetActive(false);
    }
}
