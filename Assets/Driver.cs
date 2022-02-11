using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
   float steerSpeed = 1f;
   float movespeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, 0, steerSpeed);
       transform.Translate(0 ,movespeed , 0);
    }
}
