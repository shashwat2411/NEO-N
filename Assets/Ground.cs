using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        //if (other.gameObject.CompareTag("Player")) FindObjectOfType<Player>().onGround = true;
    }
    
    private void OnCollisionExit(Collision other)
    {
        //if (other.gameObject.CompareTag("Player")) FindObjectOfType<Player>().onGround = false;
    }
}
