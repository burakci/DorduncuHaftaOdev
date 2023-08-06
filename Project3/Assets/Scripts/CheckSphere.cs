using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(transform.position,1f))
        {
            print("Çarpma gerçekleþti");
        }
        
    }
}
