using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stokeFire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fire;
    public GameObject Button;
    private void OnMouseDown()
    {
        GameObject UiHandling = GameObject.Find("UIHandler");
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
        Uihandle.fire = true;
        fire.SetActive(true);

        if (Uihandle.fireOff)
        {
            fire.SetActive(false);
            this.gameObject.GetComponent<AudioSource>();
            Button.SetActive(true);

        }
    }
}
