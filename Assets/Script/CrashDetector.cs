using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Head")
       {
           Debug.Log("Te-ai lovit de te-ai spart");
       }
   }
}
