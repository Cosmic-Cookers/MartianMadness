using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutCount : MonoBehaviour
{
    public int cutCounts = 0;
    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cut4;
    public GameObject cut5;
    public GameObject cut6;
    public GameObject cut7;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (cutCounts == 1)
            {
            if (cut1.activeInHierarchy)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            cut1.SetActive(false);
        
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
            cut3.SetActive(false);
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
            cut5.SetActive(false);
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
            cut7.SetActive(false);
                Button.SetActive(true);
         
        }

        
    }
}
