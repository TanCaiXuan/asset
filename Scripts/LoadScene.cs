using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Get the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Check if it is scene 0
        // If clicked button or pressed spacebar, load to scene 1 - Instruction Scene
        if (currentScene.buildIndex == 0 && (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)))
        {
            AudioStart.instance.Play("Button");
            SceneManager.LoadScene(1);
        }

        // Check if it is scene 1
        // If clicked button, load to scene 2 - Game Scene
        if (currentScene.buildIndex == 1 && Input.GetMouseButtonDown(0))
        {
            AudioStart.instance.Play("Button");
            SceneManager.LoadScene(2);
        }

        
    }
}
