using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GoodObstacles : MonoBehaviour
{
    
    ScoreManager scoreManager;
    // Start is called before the first frame update 

     void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
   
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("PickUp");
            Destroy(this.gameObject);
            scoreManager.IncreaseScore();

            
        }

    }
}