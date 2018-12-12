using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearedEnemiesCounter : MonoBehaviour {

    public ChallengeModeManager cmm;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyCar")
        {
            cmm.UpdateCarsCleared();
        }
    }
}
