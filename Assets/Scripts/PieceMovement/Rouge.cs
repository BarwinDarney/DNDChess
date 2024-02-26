using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rouge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.GetKey(KeyCode.Mouse0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Mouse0) == true)
        {
            print("Works");
        }
        else
        {
            print("Not work");
        }
    }
}
