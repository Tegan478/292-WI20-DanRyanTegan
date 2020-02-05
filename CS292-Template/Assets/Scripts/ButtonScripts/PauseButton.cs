using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject currPanel;

    public void OpenPanel()
    {
        print("pause pressed");
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
        currPanel.SetActive(false);
    }
}
