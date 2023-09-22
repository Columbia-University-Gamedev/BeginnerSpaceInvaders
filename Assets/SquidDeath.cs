using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
