using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingExomorph : MonoBehaviour
{
    private bool IsPicked;

    public void OnMouseDown()
    {
        IsPicked = true;
    }

    public void OnMouseUp()
    {
        IsPicked = false;
    }

    void Update()
    {
        if (IsPicked)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
