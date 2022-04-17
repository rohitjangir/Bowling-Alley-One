using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playsd;

    void OnTriggerEnter(Collider other)
    {
        playsd.Play();
        
    }
}
