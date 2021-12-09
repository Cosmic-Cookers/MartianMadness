using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script is for the eels to follow the mouse after you net them in the bowl
/// </summary>
public class followMouse : MonoBehaviour
{
    public GameObject eels;


    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "pot") //once the eels enter the pot
        {
            GameObject UiHandling = GameObject.Find("UIHandler");
            UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
            this.gameObject.SetActive(false); //set it to false
            eels.SetActive(true); //turn on the eels animation
            Uihandle.fireOff = true; //set next step to turn the fire off

        }
    }
}
