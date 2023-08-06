using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    private float deger,deger2;
    // Update is called once per frame
    void Update()
    {
        deger = Input.GetAxisRaw("Horizontal"); //raw ara de�er yok
        deger2 = Input.GetAxisRaw("Vertical");
        if (deger > 0)
        {
            print("D veya sa� ok tu�una bast�n�z.");
        }
        else if(deger == 0) 
        {
            print("Tu�lara basmad�n�z");
        }
        else
        {
            print("A veya sol ok tu�una bast�n�z");
        }

        if (deger2 > 0)
        {
            print("W veya yukar� ok tu�una bas�n�z.");
        }
        else if (deger2 == 0)
        {
            print("Tu�lara basmad�n�z");
        }
        else
        {
            print("A veya a�a�� ok tu�una bas�n�z.");
        }
    }
    
}
