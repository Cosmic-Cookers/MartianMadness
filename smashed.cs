using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smashed : MonoBehaviour
{
    private int eggclicks = 0;
    public GameObject CrackManaging;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseDown()
    {

        crackedPieceManager crack = CrackManaging.GetComponent<crackedPieceManager>();
        eggclicks++;
        gameObject.GetComponent<AudioSource>().Play();
      
        if (eggclicks == 3)
        {
            gameObject.GetComponent<Animator>().Play("smash");
            crack.smashedeggs++;

        }
  


    }

}
