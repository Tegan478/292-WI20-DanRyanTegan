using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highscore;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curr = float.Parse(score.text);
        float high = float.Parse(highscore.text);
        if (curr > high)
        {
            highscore.text = (score.text);
        }
    }
}
