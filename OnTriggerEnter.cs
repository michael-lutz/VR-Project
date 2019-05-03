using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEnter : MonoBehaviour
{
    // Created by Michael Lutz

    // Note that I made this Script to be used on other objects, so that
    // if a player collided with an object, it would load a new scene.

    public string sceneToLoad;

    // Runs Unity function when the collider (defined in the Unity Editor) is collided with
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
