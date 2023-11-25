using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SoundFile
{
    public AudioClip file;
    public float volume;
}

[System.Serializable]
public struct EnemySoundFile
{
    public SoundFile OnDamage;
    public SoundFile OnDeath;
}

[System.Serializable]
public struct WeaponSoundFile
{
    public SoundFile Shoot;
    public SoundFile BulletHit;
}

public class GameSoundPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    
    [Header("PLAYER")] 
    public SoundFile sideStep;
    public SoundFile acceleration;
    public SoundFile playerJump;
    public SoundFile playerSlow;
    
    
    [Header("SYSTEM")] 
    public SoundFile Button;
    public SoundFile Select;
    public SoundFile OnWeaponSelectScreen;
    public SoundFile[] OnTotalDamage;

    [Header("OBSTACLE")] 
    public SoundFile wallDeployment;
    public SoundFile wallBreak;
    public SoundFile wallCollision;
    public SoundFile wallCaveat;

    [Header("GAMESYSTEM")] 
    public SoundFile no2;
    public SoundFile cutin;
    
    [Header("ENEMY")]
    public SoundFile EMP;
    public SoundFile Laser;
    

    public AudioSource GetAudioSource()
    {
        return audioSource;
    }
}
