using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAnimations : MonoBehaviour
{
    public GameObject UI;
    void Start()
    {
      
        UIAnimate();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UIAnimate()
    {
        if (SceneManager.GetActiveScene().name == "KamaryStep1Pressure" || SceneManager.GetActiveScene().name == "RamenStep1" || SceneManager.GetActiveScene().name == "ExomorphStep1Egg" || SceneManager.GetActiveScene().name == "StirFryStep1")
        {
            LeanTween.moveY(UI.GetComponent<RectTransform>(), 41f, 2f).setEase(LeanTweenType.easeOutBounce);
            gameObject.GetComponent<AudioSource>().PlayDelayed(2.3f);
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep7Final" || SceneManager.GetActiveScene().name == "RamenStep5" || SceneManager.GetActiveScene().name == "FinishedExomorph")
        {
            LeanTween.scale(UI, new Vector3(1, 1, 1) , 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(.4f);
        }

    }

}
