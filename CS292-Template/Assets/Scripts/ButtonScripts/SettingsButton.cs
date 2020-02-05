using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject currPanel;

    public void OpenPanel()
    {
        print("settings pressed");
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
        currPanel.SetActive(false);
    }
}
