using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeSlashAlphaControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float alpha = 0f;
    float counter = 0f;
    float counter2 = 0f;
    public float time = 0.3f;
    void Awake()
    {
        Material material = Instantiate(GetComponent<ParticleSystemRenderer>().material);
        GetComponent<ParticleSystemRenderer>().material = material;;
    }

    void FixedUpdate()
    {
        counter += Time.deltaTime;
        if (counter <= (12.6f/100f * time))
        {
            alpha += counter / (12.6f/100f * time);
        }
        else if (counter > (12.6f/100f * time) && counter <= (50.9f/100f * time))
        {
            alpha = 1f;
        }
        else if (counter <= time)
        {
            counter2 += Time.deltaTime;
            alpha = 1f - (counter2 / (time - (50.9f / 100f * time)));
        }
        else
        {
            counter = 0f;
            counter2 = 0f;
            alpha = 0f;
        }

        Color color = GetComponent<ParticleSystemRenderer>().material.GetColor("_Color");
        GetComponent<ParticleSystemRenderer>().material.SetColor("_Color", new Color(color.r, color.g, color.b, alpha));
    }
}
