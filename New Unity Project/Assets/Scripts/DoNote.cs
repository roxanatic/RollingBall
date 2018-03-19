using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNote : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LeftHand")
        {
            audioSource.PlayOneShot(impact, 0.7F);
        }
    }

}
