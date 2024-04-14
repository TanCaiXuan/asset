using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstacle : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        
        if (collision.tag == "Player")
        {
            

            if (HealthManager.health < 0)
            {
                FindObjectOfType<AudioManager>().Play("GameOver");
                FindObjectOfType<SpawnObstacles>().DisableSpawnObject();
                FindObjectOfType<LoopingBackground>().DisableMoveBackground();
                FindObjectOfType<AudioManager>().Stop("GameTheme");
                Destroy(player.gameObject);
                DestroyObjectsWithTag("GoodAction");
                DestroyObjectsWithTag("BadAction");
                //DestroyObjectsWithTag("Heart");
            }
            else 
            {
                Destroy(this.gameObject);
                HealthManager.health--;
                FindObjectOfType<AudioManager>().Play("GameOver");
                StartCoroutine(GetHurt());
            }
            

        }
        
    }
    IEnumerator GetHurt()
    {

        Physics2D.IgnoreLayerCollision(6, 8);
        yield return new WaitForSeconds(3);
        Physics2D.IgnoreLayerCollision(6, 8, false);
    }
    void DestroyObjectsWithTag(string tag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject gameObject in objectsWithTag)
        {
            Destroy(gameObject);
        }
    }
}