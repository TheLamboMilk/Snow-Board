using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Dinu")
        {
            Debug.Log("Ai terminat fara sa mori :D");
        }
        

    }
}
