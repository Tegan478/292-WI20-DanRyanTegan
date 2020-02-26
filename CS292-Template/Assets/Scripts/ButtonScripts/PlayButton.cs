using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score;
    int count = 0;

    public void ResetScore()
    {
        score.text = count.ToString();
    }
}
