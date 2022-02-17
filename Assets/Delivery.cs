using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] float destoryDelay = 0.5f;
   bool hasPackage;
   void OnCollisionEnter2D(Collision2D other) {
       
   
   
    Debug.Log("Ouch");
   }
   
   void OnTriggerEnter2D(Collider2D other) 
   {
      if (other.tag =="Package"&& !hasPackage)
      {

         Debug.Log("Package picked up");
         hasPackage = true;
         Destroy(other.gameObject, destoryDelay);
      }

      if (other.tag == "Customer" && hasPackage){

         Debug.Log("Package Delivered");
         hasPackage = false;

      }
   
    //if the thing we trigger is the package than print package picked up

   }
        
    
}
