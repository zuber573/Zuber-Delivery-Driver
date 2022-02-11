using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField]float steerSpeed = 1f;
   [SerializeField]float movespeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed *Time.deltaTime;
       float moveAmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
       transform.Rotate(0, 0, -steerAmount);
       transform.Translate(0 ,moveAmount , 0);
    }
}
