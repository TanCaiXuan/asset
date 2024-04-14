using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    public bool loop;
    public bool playOnAwake;

    [HideInInspector]
    public AudioSource source;

}
