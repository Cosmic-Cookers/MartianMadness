using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// This is for using Tween on the book animations or text animations
/// </summary>
public class UIAnimations : MonoBehaviour
{
    public GameObject UI;
    public GameObject Button;
    void Start()
    {
      
        UIAnimate();
        StartCoroutine(Buttonoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UIAnimate()
    {
        if (SceneManager.GetActiveScene().name == "KamaryStep1Pressure" || SceneManager.GetActiveScene().name == "RamenStep1" || SceneManager.GetActiveScene().name == "ExomorphStep1Egg" || SceneManager.GetActiveScene().name == "StirFryStep1")
        {
            LeanTween.moveY(UI.GetComponent<RectTransform>(), 41f, 2f).setEase(LeanTweenType.easeOutBounce); //if it's the scene that requires the book animations, set the tween to move the book down
            gameObject.GetComponent<AudioSource>().PlayDelayed(2f); //play audio at a slight delay
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep7Final" || SceneManager.GetActiveScene().name == "RamenStep5" || SceneManager.GetActiveScene().name == "ExomorphStep7" || SceneManager.GetActiveScene().name=="StirFryStep6")
        {
            LeanTween.scale(UI, new Vector3(1, 1, 1) , 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(.4f); //if it's the scene that requries the final text to scale in size, then 
            
        }

    }
    IEnumerator Buttonoroutine() //wait a few seconds to set button active on these scenes
    {
        

        yield return new WaitForSeconds(4);
        Button.SetActive(true);


    }

}
