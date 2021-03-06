using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : MonoBehaviour
{
    private AudioSource audio;
    private float musicVolume = 1f;
    private static MusicSlider instance = null;

    public static MusicSlider Instance
    {
        get { return instance; }
    }

    void Start()
    {
        audio = Music.Instance.gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        audio.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
