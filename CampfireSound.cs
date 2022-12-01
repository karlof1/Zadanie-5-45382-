using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireSound : MonoBehaviour
{
}

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        audioSource.Play();
    }
}