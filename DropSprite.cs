using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this script is for dropping the egg for cracking scene for the exomorph
/// </summary>
public class DropSprite : MonoBehaviour
{

    private bool isDragging;
 
    public void OnMouseDown()
    {
        isDragging = true;
    }


    public void OnMouseUp()
    {
        isDragging = false;
    }


    void Update()
    {


        GameObject eggdrop = this.gameObject;
        CheckCollision eggdropped = eggdrop.GetComponent<CheckCollision>(); //find script for check collisions

        if (!eggdropped.isDrop) //if you have not dropped the egg above
        {
            if (isDragging) //allow for the egg to be dragged
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //follow position
                transform.Translate(mousePosition);
            }
        }
    }
}
