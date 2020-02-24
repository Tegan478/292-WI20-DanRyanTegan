using UnityEngine;

public class Animations : MonoBehaviour
{

    public GameObject thingToAnimate;
    public GameObject nextToAnimate;

    public void PlayAnim()
    {
        print("PlayAnim called");
        print(thingToAnimate);
        //print(thingToAnimate);
        thingToAnimate.SetActive(true);
        Animator animator = thingToAnimate.GetComponent<Animator>();
        if (animator != null)
        {
            print("animator is not null");
            bool isOpen = animator.GetBool("Open");
            animator.SetBool("Open", !isOpen);


        }

    }

    public void PlayNextAnim()
    {
        print("PlayNextAnim called");
        //print(thingToAnimate);
        nextToAnimate.SetActive(true);
        Animator animator = nextToAnimate.GetComponent<Animator>();
        if (animator != null)
        {
            print("animator is not null");
            bool isOpen = animator.GetBool("Open");
            animator.SetBool("Open", !isOpen);


        }
    }
}
