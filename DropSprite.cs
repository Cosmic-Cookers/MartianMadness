using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        CheckCollision eggdropped = eggdrop.GetComponent<CheckCollision>();

        if (!eggdropped.isDrop)
        {
            if (isDragging)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
        }
    }
}
