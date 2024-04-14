using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField] public float backgroundSpeed; 
    public Renderer backgroundRenderer;
    bool canMove = true;
 
// Update is called once per frame
     void Update()
    {
        if (canMove)
        {
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        }
            
    }

    public void DisableMoveBackground()
    {
        canMove = false;
    }
}