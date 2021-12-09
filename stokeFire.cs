using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is for the ramen scene so that you can stoke the fire
/// </summary>
public class stokeFire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fire;
    public GameObject Button;
    private void OnMouseDown()
    {
        GameObject UiHandling = GameObject.Find("UIHandler");
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
        Uihandle.fire = true; //fire is set to true at the beginning
        fire.SetActive(true); //if player clicks the fire pit, the fire is turned off

        if (Uihandle.fireOff) //if fire needs to be turned off
        {
            fire.SetActive(false); //turn off the object
            this.gameObject.GetComponent<AudioSource>(); //play sound
            Button.SetActive(true); //set button on for next steps

        }
    }
}
