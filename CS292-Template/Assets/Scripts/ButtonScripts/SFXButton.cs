using UnityEngine;

public class SFXButton : MonoBehaviour
{

    public void SFXDisable()
    {

        AudioListener.pause = !AudioListener.pause;

    }


}


