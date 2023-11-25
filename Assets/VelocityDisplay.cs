using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class VelocityDisplay : MonoBehaviour
{
    private float lerpTime = 0.0f;
    public Image hari;
    //public Image hari2;
    public ParticleSystem SpeedLine;

    //public GameObject playerposition;
    [HideInInspector] public int playervel;
    // Start is called before the first frame update
    void Start()
    {
        SpeedLine.Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playervel = (int)Player.player.rb.velocity.z;
        if (playervel >= Player.player.velMax)
        {
            if(!Player.player.isNitro && !Player.player.SuperDashMode)playervel = (int)Player.player.velMax;
        }
        if (playervel >= 200) SpeedLine.Play();
        
        GetComponent<TextMeshProUGUI>().text = "" + playervel;

        //playerposition.GetComponent<TextMeshProUGUI>().text = "" + GetComponent<Player>().transform.position.z;
       
        if (playervel >= 210)
        {
            playervel = 210;
            hari.transform.DOShakeRotation(1f, 10f, 20, 40, true);
            hari.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, hari.transform.rotation.z + 150));
        }
        
        hari.transform.DORotate(Vector3.forward * ((-playervel* 1.35f) + 150), 0.2f, mode: RotateMode.Fast);
    }
}
