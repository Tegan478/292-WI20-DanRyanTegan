using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thingToAnimate;
    public GameObject nextAnimate;
    public GameObject panelToOpen;
    public GameObject currPanel;

    public bool isPlay = false;
    public bool needsPause = false;
    public bool toResume = false;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    
    public GameObject spawner;

    public AudioSource sliceSound;
    public AudioSource sliceBuildup;

    
   public void ClosePanel()
    {
        currPanel.SetActive(false);
    }

    public void Play()
    {
        print("Play called");
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
        if (thingToAnimate != null)
        {
            StartCoroutine(PlayAnim());
        }
        else
        {
            if (panelToOpen != null)
            {
                panelToOpen.SetActive(true);
            }
            ClosePanel();
        }
    }

    IEnumerator PlayAnim()
    {
            print("PlayAnim called");
            print(thingToAnimate);
            //print(thingToAnimate);
            thingToAnimate.SetActive(true);
            Animator animator = thingToAnimate.GetComponent<Animator>();
            if (animator != null)
            {
                print(animator);
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);


        }
        
        //this is for slowing down the code, so that the animation
        //is able to play before the rest of the code executes
        //also has breaks for the sound effects
        //editing these 3 float values should always add to 3, as that is the
        //duration of the animation
        yield return new WaitForSeconds(.4f);
        sliceBuildup.Play();
        yield return new WaitForSeconds(1.0f);
        sliceSound = thingToAnimate.GetComponent<AudioSource>();
        sliceSound.Play();
        yield return new WaitForSeconds(1.6f);
        
        
        thingToAnimate.SetActive(false);
        OpenPanel();
    }

    public void OpenPanel()
    {

        print(Time.time);
        if (needsPause)
        {
            Time.timeScale = 0f;
        }

        if (toResume)
        {
            Time.timeScale = 1f;
        }

        if (panelToOpen != null)
        {
            panelToOpen.SetActive(true);
            //this works believe it or not
            if (panelToOpen.ToString() == "Panel_Gameplay (UnityEngine.GameObject)")
            {
                if (nextAnimate != null)
                {
                    //nextAnimate.SetActive(true);
                    Animator anim = nextAnimate.GetComponent<Animator>();
                    if (anim != null)
                    {
                        print(Time.time);
                        anim.SetTrigger("fromPlay");
                    }
                }
                
            }
           
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
