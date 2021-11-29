using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] float delayScene = 1f;
   [SerializeField] ParticleSystem crashEffect;
   [SerializeField] AudioClip crashSFX;
   bool hasCrashed = false;
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Head" && !hasCrashed || other.tag == "Rocks" && !hasCrashed)
       {
           hasCrashed = true;
           FindObjectOfType<PlayerController>().DisableControls();
           crashEffect.Play();
           GetComponent<AudioSource>().PlayOneShot(crashSFX);
           Invoke("ReloadScene",delayScene);
       }
   }
   void ReloadScene()
    {
      SceneManager.LoadScene(0);
    }
}
