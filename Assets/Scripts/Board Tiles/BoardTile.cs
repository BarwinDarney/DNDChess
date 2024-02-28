using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTile : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        var piece = GameObject.Find("Rouge");
        var currentPosition = piece.transform.position;
        if (collision.gameObject.tag == "Piece")
        {
            print(currentPosition);
        }   
    }
}
