using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelToOpen;
    public GameObject currPanel;

    public void OpenPanel()
    {
        print("button pressed");
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        currPanel.SetActive(false);
    }
}
