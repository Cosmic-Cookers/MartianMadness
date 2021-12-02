using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Drop : MonoBehaviour,IDropHandler
{
    public GameObject spiceanim;
    public GameObject spiceanim2;
    public AudioSource audioSource;
    public GameObject spice1;
    public GameObject spice2;
    public GameObject spice3;
    public GameObject spice4;
    private int amountDropped = 0;

    public int amountNeeded = 0;
    public GameObject Button;
    private GameObject currentSpice;
    public int numberofBowls = 0;
    


    public void OnDrop(PointerEventData eventData)
    {
        GameObject CombineManaging = GameObject.Find("Combinegame");
        CombineManager combinemanage = CombineManaging.GetComponent<CombineManager>();
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            currentSpice = eventData.pointerDrag.gameObject;
            Debug.Log(amountDropped);

                if (amountDropped == 0)
                {

                    if (currentSpice.name == "shaker" && combinemanage.shaker == 1)
                    {
                        amountDropped = 1;
                        currentSpice.SetActive(false);
                        spiceanim.SetActive(true);
                        audioSource.Play(0);
                    }
                    else if (currentSpice.name == "spice1" && combinemanage.step1 == 1)
                    {
                        amountDropped = 1;
                        currentSpice.SetActive(false);
                        
                        if (SceneManager.GetActiveScene().name == "Spice")
                        {
                            audioSource.Play(0);
                            spiceanim2.SetActive(true);
                        }
                        else
                        {
                            spice1.SetActive(true);
                            gameObject.GetComponent<AudioSource>().Play();
                        }
                        
                    }
                    else if (currentSpice.name == "spice2" && combinemanage.step2 == 1)
                    {
                        amountDropped = 1;
                        currentSpice.SetActive(false);
                        spice2.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice3" && combinemanage.step3 == 1)
                    {
                        amountDropped = 1;
                        currentSpice.SetActive(false);
                        spice3.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice4" && combinemanage.step4 == 1)
                    {
                        amountDropped = 1;
                        currentSpice.SetActive(false);
                        spice4.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }


                }
                else if (amountDropped == 1)
                {

                    if (currentSpice.name == "shaker" && combinemanage.shaker == 2)
                    {
                        amountDropped = 2;
                        currentSpice.SetActive(false);
                        spiceanim.SetActive(true);
                        audioSource.Play(0);
                    }
                    else if (currentSpice.name == "spice1" && combinemanage.step1 == 2)
                    {
                        amountDropped = 2;
                        currentSpice.SetActive(false);
                        if (SceneManager.GetActiveScene().name == "Spice")
                        {
                            audioSource.Play(0);
                            spiceanim2.SetActive(true);
                        }
                        else
                        {
                            spice1.SetActive(true);
                            gameObject.GetComponent<AudioSource>().Play();
                        }
                    }
                    else if (currentSpice.name == "spice2" && combinemanage.step2 == 2)
                    {
                        amountDropped = 2;
                        currentSpice.SetActive(false);
                        spice2.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice3" && combinemanage.step3 == 2)
                    {
                        amountDropped = 2;
                        currentSpice.SetActive(false);
                        spice3.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice4" && combinemanage.step4 == 2)
                    {
                        amountDropped = 2;
                        currentSpice.SetActive(false);
                        spice4.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }


                }
                else if (amountDropped == 2)
                {

                    if (currentSpice.name == "shaker" && combinemanage.shaker == 3)
                    {
                        amountDropped = 3;
                        currentSpice.SetActive(false);
                        spiceanim.SetActive(true);
                        audioSource.Play(0);
                    }
                    else if (currentSpice.name == "spice1" && combinemanage.step1 == 3)
                    {
                        amountDropped = 3;
                        currentSpice.SetActive(false);
                        if (SceneManager.GetActiveScene().name == "Spice")
                        {
                            audioSource.Play(0);
                            spiceanim2.SetActive(true);
                        }
                        else
                        {
                            spice1.SetActive(true);
                            gameObject.GetComponent<AudioSource>().Play();
                        }
                    }
                    else if (currentSpice.name == "spice2" && combinemanage.step2 == 3)
                    {
                        amountDropped = 3;
                        currentSpice.SetActive(false);
                        spice2.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice3" && combinemanage.step3 == 3)
                    {
                        amountDropped = 3;
                        currentSpice.SetActive(false);
                        spice3.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice4" && combinemanage.step4 == 3)
                    {
                        amountDropped = 3;
                        currentSpice.SetActive(false);
                        spice4.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }


                }

                else if (amountDropped == 3)
                {

                    if (currentSpice.name == "shaker" && combinemanage.shaker == 4)
                    {
                        amountDropped = 4;
                        currentSpice.SetActive(false);
                        spiceanim.SetActive(true);
                        audioSource.Play(0);
                    }
                    else if (currentSpice.name == "spice1" && combinemanage.step1 == 4)
                    {
                        amountDropped = 4;
                        currentSpice.SetActive(false);
                        if (SceneManager.GetActiveScene().name == "Spice")
                        {
                            audioSource.Play(0);
                            spiceanim2.SetActive(true);
                        }
                        else
                        {
                            spice1.SetActive(true);
                            gameObject.GetComponent<AudioSource>().Play();
                        }
                    }
                    else if (currentSpice.name == "spice2" && combinemanage.step2 == 4)
                    {
                        amountDropped = 4;
                        currentSpice.SetActive(false);
                        spice2.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice3" && combinemanage.step3 == 4)
                    {
                        amountDropped = 4;
                        currentSpice.SetActive(false);
                        spice3.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice4" && combinemanage.step4 == 4)
                    {
                        amountDropped = 4;
                        currentSpice.SetActive(false);
                        spice4.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }



                }
                else if (amountDropped == 4)
                {

                    if (currentSpice.name == "shaker" && combinemanage.shaker == 5)
                    {
                        amountDropped = 5;
                        currentSpice.SetActive(false);
                        spiceanim.SetActive(true);
                        audioSource.Play(0);
                    }
                    else if (currentSpice.name == "spice1" && combinemanage.step1 == 5)
                    {
                        amountDropped = 5;
                        currentSpice.SetActive(false);
                        if (SceneManager.GetActiveScene().name == "Spice")
                        {
                            audioSource.Play(0);
                            spiceanim2.SetActive(true);
                        }
                        else
                        {
                            spice1.SetActive(true);
                            gameObject.GetComponent<AudioSource>().Play();
                        }
                    }
                    else if (currentSpice.name == "spice2" && combinemanage.step2 == 5)
                    {
                        amountDropped = 5;
                        currentSpice.SetActive(false);
                        spice2.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice3" && combinemanage.step3 == 5)
                    {
                        amountDropped = 5;
                        currentSpice.SetActive(false);
                        spice3.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else if (currentSpice.name == "spice4" && combinemanage.step4 == 5)
                    {
                        amountDropped = 5;
                        currentSpice.SetActive(false);
                        spice4.SetActive(true);
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }


                }
                if (amountDropped == amountNeeded)
                {
                    Button.SetActive(true);
                }

            
        }
      
        //if (currentSpice.name == "shaker2")
        //{
        //    spiceanim2.SetActive(true);
        //    audioSource.Play(0);
        //}

        //if (numberofBowls == 4)
        //{
        //    if (currentSpice.name == "spice1")
        //    {
        //        spice1.SetActive(true);
        //        gameObject.GetComponent<AudioSource>().Play();
        //        //spice2.SetActive(true);
        //    }

        //    if (currentSpice.name == "spice2")
        //    {
        //        //spice1.SetActive(false);
        //        spice2.SetActive(true);
        //        gameObject.GetComponent<AudioSource>().Play();
        //    }

        //    if (currentSpice.name == "spice3")
        //    {
        //        //spice2.SetActive(false);
        //        spice3.SetActive(true);
        //        gameObject.GetComponent<AudioSource>().Play();


        //    }
        //    if (currentSpice.name == "spice4")
        //    {
        //        //spice2.SetActive(false);
        //        spice4.SetActive(true);
        //        gameObject.GetComponent<AudioSource>().Play();

        //    }

        //    if (amountDropped == amountNeeded)
        //    {
        //        Button.SetActive(true);
        //    }
        //}
        //else if (numberofBowls==3) {
        //    if (currentSpice.name == "spice1")
        //    {
        //        spice1.SetActive(true);
        //        gameObject.GetComponent<AudioSource>().Play();
        //        //spice2.SetActive(true);
        //    }

        //    if (currentSpice.name == "spice2")
        //    {
        //        //spice1.SetActive(false);
        //        gameObject.GetComponent<AudioSource>().Play();
        //        spice2.SetActive(true);
        //    }

        //    if (currentSpice.name == "spice3")
        //    {
        //        //spice2.SetActive(false);
        //        gameObject.GetComponent<AudioSource>().Play();
        //        spice3.SetActive(true);


        //    }
        //    if (amountDropped == amountNeeded)
        //    {
        //        Button.SetActive(true);
        //    }
        //}



    }
}
