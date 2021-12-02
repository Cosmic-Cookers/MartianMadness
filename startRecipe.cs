using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startRecipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeBook()
    {
        GameObject.Find("Canvas(1)").GetComponent<AudioSource>().Play();
        LeanTween.moveY(GameObject.Find("Image1").GetComponent<RectTransform>(), 2293f, 2f).setEase(LeanTweenType.easeOutBounce);
        GameObject.Find("Image1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("Panel").SetActive(false);

    }


}
