using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIegghandler : MonoBehaviour
{
    public bool nextUI = false;
    public GameObject button; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextUI)
        {
            button.SetActive(true); //sets button to true if next UI specificlaly for UI for the egg scene
        }
    }
}
