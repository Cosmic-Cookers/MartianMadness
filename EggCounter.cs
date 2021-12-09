using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCounter : MonoBehaviour
{
    /// <summary>
    /// counts how many eggs are finished
    /// </summary>
    public int eggCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (eggCount == 3) //if there are 3 eggs, then set the next Ui for true
        {
            GameObject UIhandle = GameObject.Find("Canvas");
            UIegghandler Uihandler = UIhandle.GetComponent<UIegghandler>();
            Uihandler.nextUI = true;
        }
    }
}
