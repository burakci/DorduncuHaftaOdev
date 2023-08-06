using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        timer += 1.5f * Time.fixedDeltaTime;
        print(timer);
    }
}
