using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLossParticle : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public GameObject particle;
    public static GameObject ninjaPop;

    // Start is called before the first frame update
    public void pop1()
    {
        ninjaPop = Instantiate(particle, new Vector3(life1.transform.position.x, life1.transform.position.y, 0), Quaternion.identity);
    }

    public void pop2()
    {
        ninjaPop = Instantiate(particle, new Vector3(life2.transform.position.x, life2.transform.position.y, 0), Quaternion.identity);
    }

    public void pop3()
    {
        ninjaPop = Instantiate(particle, new Vector3(life3.transform.position.x, life3.transform.position.y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
