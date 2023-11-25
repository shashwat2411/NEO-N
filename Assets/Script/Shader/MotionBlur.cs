using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class MotionBlur : MonoBehaviour
{
    public Material motionBlurMaterial;              // シェーダ用のマテリアル
    public float blurpower = 0f;   // ブラーの強さ
    //[SerializeField] private float blurtime = 0f;    // ブラーする時間


    private void Start()
    {
        motionBlurMaterial.SetFloat("_SpeedCoeff", 0f);
    }

    void FixedUpdate()
    {
        // シェーダー名を取得し,ブラーの強さを設定
        //if (Input.GetKey(KeyCode.J)) motionBlurMaterial.SetFloat("_SpeedCoeff", Mathf.Abs(blurpower));
        //else 

    }

    /// <summary>
    /// 画像の加工を行い、描画a
    /// </summary>
    /// <param name="source"> 元のテクスチャ </param>
    /// <param name="destination">　加工先のテクスチャ　</param>
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, motionBlurMaterial);
    }
    
}

/*
if (Input.GetKeyDown(KeyCode.E))
{
    MotionBlur blur = FindObjectOfType<MotionBlur>().GetComponent<MotionBlur>();
    blur.GetComponent<MotionBlur>().enabled = true;
}*/