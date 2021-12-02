using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    public GameObject eels;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "pot")
        {
            GameObject UiHandling = GameObject.Find("UIHandler");
            UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
            this.gameObject.SetActive(false);
            eels.SetActive(true);
            Uihandle.fireOff = true;

        }
    }
}
