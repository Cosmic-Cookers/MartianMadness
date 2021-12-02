using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextstep : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        if (SceneManager.GetActiveScene().name == "Stir")
        {
            SceneManager.LoadScene("VN_MeetXenon");
        }

        if (SceneManager.GetActiveScene().name == "Egg")
        {
            SceneManager.LoadScene("Stir");
        }

        if(SceneManager.GetActiveScene().name == "Spice")
        {
            SceneManager.LoadScene("Cutter");
        }

        if(SceneManager.GetActiveScene().name == "Cutter")
        {
            SceneManager.LoadScene("Flour");
        }

        if (SceneManager.GetActiveScene().name == "Flour")
        {
            SceneManager.LoadScene("Fry");
        }
        if (SceneManager.GetActiveScene().name == "VNBored")
        {
            SceneManager.LoadScene("KamaryStep1Pressure");
        }

        if (SceneManager.GetActiveScene().name == "KamaryStep1Pressure")
        {
            SceneManager.LoadScene("KamaryStep2CutOnion");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep2CutOnion")
        {
            SceneManager.LoadScene("KamaryStep3CutPepper");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep3CutPepper")
        {
            SceneManager.LoadScene("KamaryStep4Combine");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep4Combine")
        {
            SceneManager.LoadScene("KamaryStep5Crack");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep5Crack")
        {
            SceneManager.LoadScene("KamaryStep6Smash");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep6Smash")
        {
            SceneManager.LoadScene("KamaryStep7Final");
        }

    }
}