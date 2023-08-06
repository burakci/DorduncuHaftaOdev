using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigitB : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 pozisyon;
    public Vector3 hiz;
    // Start is called before the first frame update
    void Start()
    {
        pozisyon = new Vector3 (1, 1, 1);
        hiz = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(pozisyon);
        rb.velocity = hiz * 1000;
    }
}
