using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapEgg : MonoBehaviour
{
    private int eggclicks = 0;
    
    void Update()
    {
       

    }

    void OnMouseDown()
    {
        GameObject CrackManaging = GameObject.Find("kamarypeeled");
        crackedPieceManager crack = CrackManaging.GetComponent<crackedPieceManager>();
        eggclicks++;
        gameObject.GetComponent<AudioSource>().Play();
    
        if (eggclicks == 1)
        {
            gameObject.AddComponent<Rigidbody2D>();
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            crack.eggpiecescount++;
            
        }
       
        
    }



}
