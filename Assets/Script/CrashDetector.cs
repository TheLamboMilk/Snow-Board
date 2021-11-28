using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] float delayScene = 1f;
   [SerializeField] ParticleSystem crashEffect;
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Head")
       {
           crashEffect.Play();
           Invoke("ReloadScene",delayScene);
       }
   }
   void ReloadScene()
    {
      SceneManager.LoadScene(0);
    }
}
