using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    //Value from the slider, and it converts to volume level
    public float m_MySliderValue;
    [SerializeField]
    AnimationCurve AudioLevel;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        m_MyAudioSource.Play();
    }


    void Update()
    {

        //m_MyAudioSource.volume *= AudioLevel;
        m_MyAudioSource.volume = AudioLevel.Evaluate(m_MySliderValue);
      
        
    }
}
