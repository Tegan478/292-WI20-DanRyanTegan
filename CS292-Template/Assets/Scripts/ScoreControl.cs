using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

	public GameObject panelToOpen;
	public GameObject currPanel;

	// Start is called before the first frame update
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Food"))
		{
			Destroy(col.gameObject);
			if (life3.activeSelf)
			{
				print("3");
				life3.SetActive(false);
			}
			else if (life2.activeSelf)
			{
				print("2");
				life2.SetActive(false);
			}
			else if (life1.activeSelf)
			{
				print("1");
				life1.SetActive(false);
			}
			else
			{
				OpenPanel();
			}
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
}
