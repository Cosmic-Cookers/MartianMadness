using UnityEngine;
using System.Collections;

public class ClickManager : MonoBehaviour
{
    public bool click1 = false;
    public bool click2 = false;
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "lines")
                {
                    Debug.Log("first click true");
                    click1 = true;
                }
                else
                {
                    click1 = false;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "lines")
                {
                    Debug.Log("second click true");
                    click2 = true;

                }
                else
                {
                    click2 = false;
                }
            }
        }

        if (click1 && click2)
        {
            Debug.Log("CUT");
        }


    }

}
