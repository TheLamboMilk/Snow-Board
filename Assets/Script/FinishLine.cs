using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayScene = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Dinu")
        {
            Invoke("ReloadScene",delayScene);
        }
        
    }

    void ReloadScene()
    {
      SceneManager.LoadScene(0);
    }
}
