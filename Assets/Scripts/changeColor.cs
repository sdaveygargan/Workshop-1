using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {
  
  public bool ChangeColorRed = true; // Adds a Public Variable that can change value in the Editor
  
  void OnCollisionEnter () { // This function run when the object has a collision
  
    if (ChangeColorRed == true){
    
      // Finds the component Renderer, and change the color of the Material to red
      gameObject.GetComponent<Renderer>().material.color = Color.red;
      
    } else {
    
      gameObject.GetComponent<Renderer>().material.color = Color.blue;
      
    }    
   }
}
