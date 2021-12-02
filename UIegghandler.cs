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
            button.SetActive(true);
        }
    }
}
