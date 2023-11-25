using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FlameParticle : MonoBehaviour
{
    private ParticleSystem part;
    //public WeaponBase weapon = null;
    List<ParticleCollisionEvent> collisionEvents;
    public LayerMask desiredLayers1; 
    public LayerMask desiredLayers2; 

    
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
        
        var collidesWith = part.collision.collidesWith;

        //if (weapon.OnPlayer) collidesWith = desiredLayers1;
        //else collidesWith = desiredLayers2;
        
        //Destroy(this.gameObject, 2f);
    }
    
    private void FixedUpdate()  
    {
        if (part.isStopped) //パーティクルが終了したか判別
        {
            //Destroy(this.gameObject);//パーティクル用ゲームオブジェクトを削除
        }
        
          


    }


    /*void OnTriggerEnter(Collider other)
    {
        weapon.OnHit(other.gameObject);
    }*/

    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        int i = 0;

        while (i < numCollisionEvents)
        {
            if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
            {
               //weapon.OnHit(other.gameObject);
            }
            //if (other.gameObject.CompareTag("Enemy") && weapon.OnPlayer == true) FindObjectOfType<Observer>().rpgDamage += weapon.AttackPower;
            i++;
        }
    }
}