using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This is for the cracking the egg scene
/// </summary>
public class tapEgg : MonoBehaviour
{
    private int eggclicks = 0;
    

    void OnMouseDown()
    {
        GameObject CrackManaging = GameObject.Find("kamarypeeled");
        crackedPieceManager crack = CrackManaging.GetComponent<crackedPieceManager>(); //get reference to the crack manager
        eggclicks++; //If tapped, then increase click.
        gameObject.GetComponent<AudioSource>().Play(); //play tap sound
    
        if (eggclicks == 1)
        {
            gameObject.AddComponent<Rigidbody2D>(); //allow cracked piece to fall
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3; //place infront of other objects
            gameObject.GetComponent<PolygonCollider2D>().enabled = false; //turn off collider
            crack.eggpiecescount++; //increase how many pieces have been cracked
            
        }
       
        
    }



}
