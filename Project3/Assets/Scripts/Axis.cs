using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    private float deger,deger2;
    // Update is called once per frame
    void Update()
    {
        deger = Input.GetAxisRaw("Horizontal"); //raw ara deðer yok
        deger2 = Input.GetAxisRaw("Vertical");
        if (deger > 0)
        {
            print("D veya sað ok tuþuna bastýnýz.");
        }
        else if(deger == 0) 
        {
            print("Tuþlara basmadýnýz");
        }
        else
        {
            print("A veya sol ok tuþuna bastýnýz");
        }

        if (deger2 > 0)
        {
            print("W veya yukarý ok tuþuna basýnýz.");
        }
        else if (deger2 == 0)
        {
            print("Tuþlara basmadýnýz");
        }
        else
        {
            print("A veya aþaðý ok tuþuna basýnýz.");
        }
    }
    
}
