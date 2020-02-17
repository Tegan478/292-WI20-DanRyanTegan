using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

	public GameObject panelToOpen;
	public GameObject currPanel;

	public Text scoreHUD;
	public Text endGameScore;

	public LifeLossParticle nin;
	// Start is called before the first frame update

	void Start()
	{
		scoreHUD.text = "0";
		endGameScore.text = "0";
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Food"))
		{
			Destroy(col.gameObject);
			if (life3.activeSelf)
			{
				nin.pop3();
				life3.SetActive(false);
			}
			else if (life2.activeSelf)
			{
				nin.pop2();
				life2.SetActive(false);
			}
			else if (life1.activeSelf)
			{
				nin.pop1();
				life1.SetActive(false);
			}
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
}
