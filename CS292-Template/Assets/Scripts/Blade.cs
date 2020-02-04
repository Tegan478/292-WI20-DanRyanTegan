using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    bool cutting = false;
    Rigidbody2D rb;
    Camera cam;

    public GameObject bladeTrail;
    private GameObject currBladeTrail;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            StartCut();
        } else if (Input.GetMouseButtonUp (0))
        {
            StopCut();
        }

        if (cutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut()
    {
        Vector2 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPos;
    }

    void StartCut()
    {
        cutting = true;
        currBladeTrail = Instantiate(bladeTrail, transform);
    }

    void StopCut()
    {
        cutting = false;
        currBladeTrail.transform.SetParent (null);
        Destroy(currBladeTrail, 2f);
    }
}

//https://youtu.be/nzeaFOkuHJc?t=490
