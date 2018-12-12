using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    public GameObject explosionObj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayExplosion();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "EnemyCar")
        {
            Destroy(collision.gameObject);
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionObj);
        // set position of explosion
        explosion.transform.position = transform.position;
    }
}
