using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This script is for the cutting sections of the recipe. Everytime a plyer does a cut, it set sup the next slice.
/// </summary>
public class cutCount : MonoBehaviour
{
    public int cutCounts = 0; //cut counter
    /// <summary>
    /// Refers to the cut guidelines in inspector
    /// </summary>
    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cut4;
    public GameObject cut5;
    public GameObject cut6;
    public GameObject cut7;

    public GameObject Button; 
    /// <summary>
    /// visual novel section if it's ramen recipe
    /// </summary>
    public GameObject Panel;
    public GameObject Margo_thinking;
    public GameObject Quincy_expressionless;
    public GameObject Margo_disappointed;
    public GameObject Quincy_surprised;

    public Text talk;

   

    // Update is called once per frame
    void Update()
    {
            if (cutCounts == 1) //based on number of counts
            {
                if (cut1.activeInHierarchy) //if it is active within the hierarchy, play the laser slice sound attached
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                Panel.SetActive(true); //on first cut, set the panel as true
                cut1.SetActive(false); //set the current slice guide off and next gguide 
        
                cut2.SetActive(true);
            
            }
            if (cutCounts == 2)
            {
                if (cut2.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                cut2.SetActive(false);
         
                cut3.SetActive(true);
        
            }

            if (cutCounts == 3)
            {
                if (cut3.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                talk.text = "I mean, I get that I’m different so he doesn’t trust me. But why does he hate humans so much?"; //on step three add text
                Quincy_expressionless.SetActive(false); //set previous expression false
                Margo_disappointed.SetActive(true); //set current expression
                cut3.SetActive(false); //remove old cut and add new cut line
                cut4.SetActive(true);

             }
            if (cutCounts == 4)
            {
                if (cut4.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                cut4.SetActive(false);
                cut5.SetActive(true);
         
        }
            if (cutCounts == 5)
            {
                if (cut5.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                    talk.text = "You’re telling me that you never learned about the colonization of Mars and what happened to the original Martians?"; //visal novel text

                    Margo_disappointed.SetActive(false); //expression set
                    Quincy_surprised.SetActive(true);
                    cut5.SetActive(false); //line guide set
                    cut6.SetActive(true);
        
        }

            if (cutCounts == 6)
            {
                if (cut6.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                cut6.SetActive(false);
                cut7.SetActive(true);
      
        }

            if (cutCounts == 7)
            {
                if (cut7.activeInHierarchy)
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }
                    talk.text = "I learned that Humans found that Mars could support life, so they traveled to Mars and brought their technology and civilization with them.";

                    Quincy_surprised.SetActive(false);
                    Margo_thinking.SetActive(true);
                    cut7.SetActive(false);
                    Button.SetActive(true);
         
        }

        
    }
}
