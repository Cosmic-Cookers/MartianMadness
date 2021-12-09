using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Utilizing tween to move the UI
/// </summary>
public class startRecipe : MonoBehaviour
{
   

    public void closeBook() //close book would allow the book UI to move back up the screen
    {
        GameObject.Find("Canvas(1)").GetComponent<AudioSource>().Play(); //sound
        LeanTween.moveY(GameObject.Find("Image1").GetComponent<RectTransform>(), 2293f, 2f).setEase(LeanTweenType.easeOutBounce);
        GameObject.Find("Image1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("Panel").SetActive(false);

    }


}
