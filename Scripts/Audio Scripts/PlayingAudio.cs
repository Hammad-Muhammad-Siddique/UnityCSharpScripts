using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingAudio : MonoBehaviour
{
    public AudioClip Sound; // assign an audio to this vairable in the Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        // play the sound audio
        GetComponent<AudioSource>().PlayOneShot(Sound);
    }
}