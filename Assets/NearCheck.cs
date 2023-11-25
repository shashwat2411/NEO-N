using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearCheck : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Enemy")) Player.player.nearCheck = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Enemy")) Player.player.nearCheck = false;
    }
}
