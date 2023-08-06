using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPalet : MonoBehaviour
{

    public Vector3 yon;
   
    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(yon);
    }
}
