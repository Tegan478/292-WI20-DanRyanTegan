using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelToOpen;
    public GameObject currPanel;

    public bool isPlay = false;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public void OpenPanel()
    {
        //print("button pressed");
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        currPanel.SetActive(false);

        if (isPlay)
        {
            Blade.count = 0;
            ResetCounters();
        }
    }

    public void ResetCounters()
    {
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
    }
}
