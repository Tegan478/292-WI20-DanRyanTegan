using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScore : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void clear()
    {
        PlayerPrefs.SetFloat("highscore", 0);
    }
    // Update is called once per frame
    void Update()
    {
        score.text = (PlayerPrefs.GetFloat("highscore")).ToString();
    }
}
