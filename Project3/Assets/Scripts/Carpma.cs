using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    /*
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }
}
