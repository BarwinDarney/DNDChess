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
        getInput();  
      
    }
    public bool getInput()
    {
        bool inputDetected = false;
        if (Input.GetKey(KeyCode.Mouse0) == true)
        {
            print("Works");
            inputDetected = true;
        }
        else
        {
            print("Not work");
        }
        return inputDetected;
    }
}
