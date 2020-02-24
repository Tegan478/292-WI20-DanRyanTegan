using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelToOpen;
    public GameObject currPanel;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public Text scoreHUD;
    public static float score = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bomb"))
        {
            Destroy(col.gameObject);
            OpenPanel();
        } 
    }

    public void OpenPanel()
    {
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        currPanel.SetActive(false);
    }

   

    // Update is called once per frame

    void Update()
    {
        if (!life1.activeSelf)
        {
            //string temp = scoreHUD.text;
            //score = int.Parse(temp);
            OpenPanel();
        }
    }
}
