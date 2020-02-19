using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelToOpen;
    public GameObject thingToAnimate;
    public GameObject currPanel;

    public bool isPlay = false;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    
    public GameObject spawner;

    public void PlayAnim()
    {
        print("PlayAnim called");
        thingToAnimate.SetActive(true);
        Animator animator = thingToAnimate.GetComponent<Animator>();
        if (animator != null)
        {
            print("animator is not null");
            bool isOpen = animator.GetBool("Open");
            animator.SetBool("Open", !isOpen);
            

        }
    }
   public void ClosePanel()
    {
        currPanel.SetActive(false);
    }

    public void Play()
    {
        Blade.chip = 0;
        Blade.coffee = 0;
        Blade.soda = 0;
        Blade.cookie = 0;
        Blade.popsicle = 0;
        Blade.noodle = 0;
        Blade.eggs = 0;
        Blade.sandwich = 0;

        Blade.count = 0;
        Spawner.startTimeBtwSpawns = 1.1f;
        ResetCounters(); ;

        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        ClosePanel();
    }

    public void OpenPanel()
    {
        print("OpenPanel called");

        if (isPlay)
        {
            Blade.chip = 0;
            Blade.coffee = 0;
            Blade.soda = 0;
            Blade.cookie = 0;
            Blade.popsicle = 0;
            Blade.noodle = 0;
            Blade.eggs = 0;
            Blade.sandwich = 0;

            Blade.count = 0;
            Spawner.startTimeBtwSpawns = 1.1f;
            ResetCounters();
        }

        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
        }
        ClosePanel(); 

    }

    public void ResetCounters()
    {
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
    }
}
