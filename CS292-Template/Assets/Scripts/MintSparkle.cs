using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MintSparkle : MonoBehaviour
{
    public GameObject mintPart;

    GameObject mintspark;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        mintspark = Instantiate(mintPart, transform.position, Quaternion.identity);
        rb = mintspark.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Food.bombforce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
