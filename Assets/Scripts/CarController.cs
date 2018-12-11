using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public float boundaryLeft = -1.9f;
    public float boundaryRight = 2f;
    public GameObject explosionObj;
    public AudioManager am;
    public RaceManager rm;
    Vector2 position;   // temporary position of car

	// Use this for initialization
	void Start () {
        am.carSound.Play();
        position = transform.position;  // current position of car
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime; // get input from left and right
        position.x = Mathf.Clamp(position.x, boundaryLeft, boundaryRight);    // setting track boundaries
        transform.position = position;
    }

    // gets call when car collides with any other cars
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyCar")
        {
            am.carSound.Stop();
            PlayExplosion();
            Destroy(gameObject);
            rm.StopGame();
            am.carSound.Stop();
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionObj);
        // set position of explosion
        explosion.transform.position = transform.position;
        // play explosion sound
        am.explosionSound.Play();
    }
}
