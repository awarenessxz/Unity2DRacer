using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart : MonoBehaviour {

    public GameObject countDown;
    public AudioManager am;

    // Use this for initialization
    void Start () {
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
        am.carSound.Play();
        countDown.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
