using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(GetComponent<BoxCollider>().bounds.max.y);
    }

}
