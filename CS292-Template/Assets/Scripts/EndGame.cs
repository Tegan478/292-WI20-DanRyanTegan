using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelToOpen;
    public GameObject currPanel;

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
        //print("button pressed");
        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        currPanel.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
