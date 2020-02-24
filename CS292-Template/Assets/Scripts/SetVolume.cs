using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f); //set the value to the music volume at start
    }
    void Update() //make it make sure it is set to the current volume level
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f); //set the value to the music volume at start

    }
    public void SetLevel(float sliderValue) //when we move the slider
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20); //sets the volume to the slidervalue
        PlayerPrefs.SetFloat("MusicVolume", sliderValue); //sets the volume to the slider value

    }
}