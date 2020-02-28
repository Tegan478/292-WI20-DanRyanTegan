using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject panelToOpen;
    public void OpenPanel()
    {
        // print(panelToOpen);
        //print("sfx button pressed");
        if (panelToOpen != null)
        {
            //print(panelToOpen.activeSelf);
            if (panelToOpen.activeSelf)
            {
                panelToOpen.SetActive(false);
            }
        }
    }
}
