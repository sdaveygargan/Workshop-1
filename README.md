![Welcome Demo](Demo/demo.gif)

**The University of Melbourne**
# COMP30019 – Graphics and Interaction

## Workshop 1

# Introduction:

In this lab you will be introduced to Unity, a powerful games and simulation engine which facilitates the construction of rich interactive scenes.

Start by opening `Scenes > Main`.

* **Main.unity** - This is the main file where we are going to recreate the behaviors that you see in the scene.

In the center you can see a `Play` Button. Click on it and the simulation will start. You should be able to see the same action as the gif at the top of this README.
Make sure to understand the diference between the `Scene tab` and the `Game tab`. During play you can see the Game tab and while out of play you use the scene tab.

Explore this scene, in the `Hierarchy` (on the left) you can see all the `GameObjects` that are part of the scene:

* **Main Camera** - Viewpoint of the player, moving this GameObject position makes the player move.
* **Directional Ligth** - The Sun in the scene.
* **Top Ball and Bottom Ball** - Balls that include physics (`RigidBody`) and a script to change their color on Collision.
* **Plane** - The ground of this simulation.
* **Canvas - Text UI** - This GameObject is not part of the Player scene but is part of the Player User Interface.
* **Text 3D Object** - Text as an Object which is part of the player scene.

Everything in Unity needs to be part of a `GameObject`, but not all GameObjects need a visual body (`Main Camera` does not have a body). GameObjects can be Empty!

# Inspector

Click on the top ball,  and then look at the `Inspector` (on the right) where you can see diferent `Components`. The components are `Sphere (Mesh Filter)`, `Mesh Renderer`, `Sphere Collider`, `Rigidbody`, `Change Color (Script)`, and `Default-Material`. To learn more about them click on the `?` and read the documentation from Unity.

![Learn Components](Demo/LearnComponents.gif)

# Script
The `Change Color (Script)` component is our code:

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {
  
  public bool ChangeColorRed = true; // Adds a Public Variable that can change value in the Editor
  
  void OnCollisionEnter () { // This function runs when the object has a collision
  
    if (ChangeColorRed == true){
    
      // Finds the component Renderer, and changes the color of the Material to red
      gameObject.GetComponent<Renderer>().material.color = Color.red;
      
   	} else {
    
      gameObject.GetComponent<Renderer>().material.color = Color.blue;
      
   	}    
   }
}
```


# Task - Recreate the Scene

The best way of learning Unity is by using it. The objective is to start with a new file and recreate the one you explored.

Click on `File > New Scene` to start from an empty scene. You should be able to see that it start with 2 Game Objects: `MainCamera` and `Directional light`.

Add a GameObject by selecting the `+` 

![Learn Components](Demo/AddGameObject.gif)

With the help of your Tutor and the `Main` Scene make sure that all `Game Objects` have all the components needed.

Good Luck!

 **Don't forget to save your scene, then use GitHub Desktop to commit and push your changes to the repository.** 

Do not forget to ask:

**How can I run code in Unity?**

**How does the Update function work?**

