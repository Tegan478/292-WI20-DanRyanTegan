using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject currPanel;
    
    public void OpenPanel()
    {
        print("play pressed");
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
        currPanel.SetActive(false);
    }
}
