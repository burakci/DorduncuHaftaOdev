using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFlop : MonoBehaviour
{
    private bool aciksa;
    public GameObject flashLight;
    // Start is called before the first frame update
    void Start()
    {
        aciksa = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (aciksa)
            {
                flashLight.GetComponent<Light>().enabled = false;
                aciksa = false;
            }
            else
            {
                flashLight.GetComponent<Light>().enabled = true;
                aciksa = true;
            }
        }
        
    }
}
