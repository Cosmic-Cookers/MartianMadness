using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is for the smashing egg scene in kamary salad. It will play the sounds 
/// </summary>
public class smashed : MonoBehaviour
{
    private int eggclicks = 0;
    public GameObject CrackManaging;

    void OnMouseDown()
    {

        crackedPieceManager crack = CrackManaging.GetComponent<crackedPieceManager>(); //find reference to cracking manager
        eggclicks++; //everytime the object is clicked, add to how many times it is clicked
        gameObject.GetComponent<AudioSource>().Play(); //play smashing sound
      
        if (eggclicks == 3) //if you get to 3 clicks
        {
            gameObject.GetComponent<Animator>().Play("smash"); //play smash animation
            crack.smashedeggs++; //increase how many smashed eggs are in a scene

        }
  


    }

}
