using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahKontrol : MonoBehaviour
{
    RaycastHit hit;
    void Update()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null) {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, Mathf.Infinity))
                {
                    if (hit.collider.gameObject.CompareTag("dusman"))
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }    
    }
}
