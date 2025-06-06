using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public List<AudioClip> clipList;

    public VolumeManager volumeManager;

    public enum SoundType
    {
        TypeVictory,
        TypeBTN
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();


        volumeManager = GameObject.Find("VolumeManager").GetComponent<VolumeManager>();
        if (volumeManager != null)
        {
            audioSource.mute = volumeManager.silenciar;
        }
    }

    public void PlaySound(SoundType clipType)
    {
        audioSource.PlayOneShot(clipList[(int)clipType]);
    }

    public void SomBTN()
    {
        PlaySound(SoundManager.SoundType.TypeBTN);
    }

    public void SomVictory()
    {
        PlaySound(SoundManager.SoundType.TypeVictory);
    }
}
