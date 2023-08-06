using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracKontrol : MonoBehaviour
{
    public WheelCollider sagOn, sagArka, solOn, solArka;
    public float hiz,donmeHiz;
    
    void Update()
    {
        sagArka.motorTorque = hiz * Input.GetAxis("Vertical");
        solArka.motorTorque = hiz * Input.GetAxis("Vertical");

        sagOn.steerAngle = donmeHiz * Input.GetAxis("Horizontal");
        solOn.steerAngle = donmeHiz * Input.GetAxis("Horizontal");

    }
}
