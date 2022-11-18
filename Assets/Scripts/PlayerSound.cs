using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioSource jumpSfx;
    public AudioClip[] jumpClips;
    public AudioSource dieSfx;
    public AudioClip[] dieClips;


    public void PlayRandomJumpSfx()
    {
        PlayRandomSound(jumpSfx, jumpClips);
    }
    
    public void PlayRandomDieSfx()
    {
        PlayRandomSound(dieSfx, dieClips);
    }


    private void PlayRandomSound(AudioSource audioSource, AudioClip[] clips)
    {
        var randomClipIndex = Random.Range(0, clips.Length);
        var randomClip = clips[randomClipIndex];
        audioSource.clip = randomClip;
        audioSource.Play();
    }
}
