using UnityEngine;

public class SFXButton : MonoBehaviour
{
    public GameObject[] items;
    public AudioSource button;


    public void SFXDisable()
    {
        button.mute = !button.mute;
        foreach (GameObject item in items)
       {
            item.GetComponent<AudioSource>().mute = !item.GetComponent<AudioSource>().mute;
       }
        
        

    }


}


