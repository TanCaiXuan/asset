using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField] public GameObject gameOverPanel;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }

    }

    public void Restart()
    {
        AudioStart.instance.Play("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}