using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour {

    public float speed;
    bool trackMoving;
    Vector2 offset;

	// Use this for initialization
	void Start () {
        trackMoving = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (trackMoving)
        {
            offset = new Vector2(0, Time.time * speed); // y-axis will move as time increase
        } else
        {
            offset = new Vector2(0, 0);
        }
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}

    // stop the track
    public void TrackStop()
    {
        trackMoving = false;
    }
}
